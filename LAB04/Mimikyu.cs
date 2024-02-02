using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    public class Mimikyu : Pokemon
    {
        public Mimikyu() {
            name = "Mimikyu";
            id = 778;
            level = 1;
            type = PokemonType.Ghost;
            type = PokemonType.Fairy;
            abilities = PokemonAbilities.Disguise;
        }
    }
}
