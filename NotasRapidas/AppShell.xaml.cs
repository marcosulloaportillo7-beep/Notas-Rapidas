using NotasRapidas.ViewModels;
using NotasRapidas.Views;

namespace NotasRapidas
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(
                nameof(DetalleNotaPage),
                typeof(DetalleNotaPage));
        }
    }
}