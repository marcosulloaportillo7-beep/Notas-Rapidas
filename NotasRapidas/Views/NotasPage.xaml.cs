using NotasRapidas.Models;
using NotasRapidas.Services;
namespace NotasRapidas.Views;
using System.Linq;

public partial class NotasPage : ContentPage
{
    private readonly NotasDatabase db;

    public NotasPage(NotasDatabase database)
    {
        InitializeComponent();
        db = database;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        NotasCollection.ItemsSource =
            await db.GetNotasAsync();
    }

    private async void NuevaNota_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(DetalleNotaPage));
    }

    private async void NotasCollection_SelectionChanged(
        object sender,
        SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not Nota nota)
            return;

        string accion = await DisplayActionSheetAsync(
            "Opciones",
            "Cancelar",
            null,
            "Editar",
            "Eliminar");

        if (accion == "Editar")
        {
            string nuevoTitulo = await DisplayPromptAsync(
                "Editar nota",
                "Nuevo título:",
                initialValue: nota.Titulo);

            if (!string.IsNullOrWhiteSpace(nuevoTitulo))
            {
                nota.Titulo = nuevoTitulo;

                await db.SaveNotaAsync(nota);

                await db.AddHistorialAsync(
                    $"Se editó la nota {nota.Titulo}");

                NotasCollection.ItemsSource =
                    await db.GetNotasAsync();
            }
        }

        if (accion == "Eliminar")
        {
            bool confirmar = await DisplayAlertAsync(
                "Eliminar",
                $"¿Eliminar '{nota.Titulo}'?",
                "Sí",
                "No");

            if (confirmar)
            {
                await db.DeleteNotaAsync(nota);

                await db.AddHistorialAsync(
                    $"Se eliminó la nota {nota.Titulo}");

                NotasCollection.ItemsSource =
                    await db.GetNotasAsync();
            }
        }

        ((CollectionView)sender).SelectedItem = null;
    }
}