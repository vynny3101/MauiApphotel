using MauiApphotel.Models;

namespace MauiApphotel
{
    public partial class App : Application
    {
        public List<Quarto> Lista_Quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao ="Suíte Super Luxo",
                ValorDiariaadulto = 150.0,
                ValorDiariaCrianca = 70.0
            },
             new Quarto()
            {
                Descricao ="Suíte Luxo",
                ValorDiariaadulto = 110.0,
                ValorDiariaCrianca = 50.0
            },
              new Quarto()
            {
                Descricao ="Suíte Solteiro",
                ValorDiariaadulto = 100.0,
                ValorDiariaCrianca = 45.0
            },
               new Quarto()
            {
                Descricao ="Suíte padrão",
                ValorDiariaadulto = 70.0,
                ValorDiariaCrianca = 30.0
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}