using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    public class Voltorb : Pokemon
    {
        public Voltorb()
        {
            name = "Voltorb";
            id = 100;
            level = 2;
            type = PokemonType.Electric;
            abilities = PokemonAbilities.Soundproof;
            abilities = PokemonAbilities.Static;
            abilities = PokemonAbilities.Aftermatch;
        }
    }
}
