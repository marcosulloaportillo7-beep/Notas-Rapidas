using NotasRapidas.Models;
using NotasRapidas.Services;

namespace NotasRapidas.Views;

public partial class DetalleNotaPage : ContentPage
{
    private readonly NotasDatabase db;

    public DetalleNotaPage(NotasDatabase database)
    {
        InitializeComponent();
        db = database;
    }

    private async void Guardar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TituloEntry.Text))
        {
            await DisplayAlertAsync(
                "Error",
                "El título es obligatorio",
                "OK");

            return;
        }

        Nota nota = new()
        {
            Titulo = TituloEntry.Text,
            Contenido = ContenidoEditor.Text,
            FechaCreacion = DateTime.Now
        };

        await db.SaveNotaAsync(nota);

        await db.AddHistorialAsync(
            $"Se creó la nota {nota.Titulo}");

        await Shell.Current.GoToAsync("..");
    }
}