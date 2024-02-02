using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    public class Mewtwo : Pokemon
    {
        public Mewtwo() {
            name = "Mewtwo";
            id = 150;
            level = 1;
            type = PokemonType.Phychic;
            abilities = PokemonAbilities.Pressure;
            abilities = PokemonAbilities.Unnerve;
        }
    }
}
