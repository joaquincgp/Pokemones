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
        public async Task<List<PokemonItem>> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=20&offset=20";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            ListPokemons listPokemons = JsonConvert.DeserializeObject<ListPokemons>(json);
            return listPokemons.results;
        }
    }
}
