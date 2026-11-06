using NotasRapidas.Services;
namespace NotasRapidas.Views;

public partial class HistorialPage : ContentPage
{
    private readonly NotasDatabase db;

    public HistorialPage(NotasDatabase database)
    {
        InitializeComponent();
        db = database;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        HistorialCollection.ItemsSource =
            await db.GetHistorialAsync();
    }
}