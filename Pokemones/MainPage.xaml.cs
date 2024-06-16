using Pokemones.Services;

namespace Pokemones
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void CargarData()
        {
            PokemonServices pokemonServices = new PokemonServices();
            var listadoPokemones = pokemonServices.DevuelveListadoPokemones();
        }
    }

}
