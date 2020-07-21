using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeApplication.CharacterClasses
{
    public class Player : Entity
    {

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
            Strength = rand.Next(3,5);
            Speed = rand.Next(3, 5);
            Health = rand.Next(3, 5);
            Intelligence = rand.Next(3, 5);
        }
    }
}
