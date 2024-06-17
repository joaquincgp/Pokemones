using ABI.System;
using Newtonsoft.Json;
using Pokemones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pokemones.Services
{
    public class PokemonServices
    {

        public HttpClient _httpClient;
        public PokemonServices()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<PokemonItem>> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=20&offset=20";
            string json = await _httpClient.GetStringAsync(url);

            ListPokemons listPokemons = JsonConvert.DeserializeObject<ListPokemons>(json);
            return listPokemons.results;
        }
        public async Task<PokemonInfo> DevuelveCaracteristicasPokemones(string url)
        {
            string json = await _httpClient.GetStringAsync(url);
            PokemonInfo caracteristicas = JsonConvert.DeserializeObject<PokemonInfo>(json);
            return caracteristicas;
        }
    }}
