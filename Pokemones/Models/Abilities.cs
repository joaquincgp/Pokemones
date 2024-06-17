using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemones.Models
{
    public class Abilities
    {
        public bool is_hidden {  get; set; }
        public Ability ability { get; set; }
        public int slot { get; set; }

    }
}
