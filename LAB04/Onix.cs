using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    public class Onix :  Pokemon
    {
        public Onix() {
            name = "Onix";
            id = 95;
            level = 1;
            type = PokemonType.Rock;
            type = PokemonType.Ground;
            abilities = PokemonAbilities.RockHead;
            abilities = PokemonAbilities.Sturdy;
            abilities = PokemonAbilities.WeakArmor;
        }
    }
}
