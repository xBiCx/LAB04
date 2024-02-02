using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    public class Pikachu : Pokemon
    {
        public Pikachu() {
            name = "Pikachu";
            id = 25;
            level = 1;
            type = PokemonType.Electric;
            abilities = PokemonAbilities.LightningRod;
            
        }
    }
}
