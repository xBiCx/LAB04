using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    public class Pokemon
    {
        protected int id;
        protected string name;
        protected Image pic;
        protected int level;
        protected PokemonType type;
        protected PokemonAbilities abilities;
        protected int HP;
        protected int Att;
        protected int Def;
        protected int SAtt;
        protected int SDef;
        protected int Speed;

        public string Name()
        {
            return name;
        }
        public Image Picture()
        {
            return pic;
        }
    }
    
    public enum PokemonType {
        Grass, Posion, Electric, Phychic, Fire, Flying, Water, Bug, Normal, Ground, Fairy, Fighting, Rock, Ice, Ghost, Dragon, Steel, Dark, 
    }
    public enum PokemonAbilities { 
        Overgrow, chlorophyII, Static, LightningRod, Pressure, Unnerve, RockHead, Sturdy, SandVeil, Disguise, WeakArmor, Soundproof, Aftermatch, Pickup, Technician
    }
}
