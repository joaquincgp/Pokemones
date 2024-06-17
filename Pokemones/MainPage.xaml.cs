using Newtonsoft.Json;
using Pokemones.Models;
using Pokemones.Services;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Pokemones
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private List<PokemonItem> _listado_pokemones;

        public List<PokemonItem> listado_pokemones
        {
            get { return _listado_pokemones; }
            set
            {
                _listado_pokemones = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            CargarData();
        }



        public async void CargarData()
        {
            PokemonServices pokemonServices = new PokemonServices();
            listado_pokemones = await pokemonServices.DevuelveListadoPokemones();
           
        }

        public async void MostrarInfoPokemon(object sender, SelectedItemChangedEventArgs e)
        {
            PokemonItem poke_info = (PokemonItem)e.SelectedItem;
            Navigation.PushAsync(new ResumenPokemon(poke_info.url));

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
