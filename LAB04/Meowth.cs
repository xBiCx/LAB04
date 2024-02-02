using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    public class Meowth : Pokemon
    {
        public Meowth()
        {
            name = "Meowth";
            id = 52;
            level = 3;
            type = PokemonType.Normal;
            abilities = PokemonAbilities.Pickup;
            abilities = PokemonAbilities.Technician;
            abilities = PokemonAbilities.Unnerve;
        }
    }
}
