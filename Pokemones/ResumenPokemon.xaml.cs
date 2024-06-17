using Newtonsoft.Json;
using Pokemones.Models;
using Pokemones.Services;
using System;
using System.Diagnostics;

namespace Pokemones;

public partial class ResumenPokemon : ContentPage
{
    PokemonInfo caracteristicas = new PokemonInfo();


    public ResumenPokemon(string url)
	{
        InitializeComponent();
        CargarPokemon(url);
    }

	public async void CargarPokemon(string url)
	{
		PokemonServices poke_services = new PokemonServices();
		caracteristicas = await poke_services.DevuelveCaracteristicasPokemones(url);
		Debug.WriteLine(JsonConvert.SerializeObject(caracteristicas));
		ImagenPokemon.Source = caracteristicas.sprites.front_default;

		string habilidades = "";
		foreach(var ability in  caracteristicas.Abilities)
		{
			habilidades += ability.ability.name + " | ";
		}
		Habilidades.Text = habilidades;
	}
}