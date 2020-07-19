using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeApplication.CharacterClasses
{
    public class Player : Entity
    {
        Random rand = new Random();

        public Player() : base()
        {

        }

        public Player(string name, EntitySex eSex, EntityClass eClass) : base()
        {
            Name = name;
            Sex = eSex;
            CharacterClass = eClass;
        }

        public Player(string name, EntitySex eSex, EntityClass eClass, int strength, int speed, int health, int intelligence)
        {
            Name = name;
            Sex = eSex;
            CharacterClass = eClass;
            Strength = strength;
            Speed = speed;
            Health = health;
            Intelligence = intelligence;
        }
    }
}
