using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeApplication.CharacterClasses
{
    public class Student : Entity
    {

        //Parameter-less Constructor
        public Student() : base()
        {
        }

        //Create the specific student
        public Student(string name, EntitySex sex) : base()
        {
            //Add formulas for genderating stats
            //Base those formulas on the Class
            _name = name;
            _sex = sex;
            _intelligence = rand.Next(4, 8);
        }

        //Create the customized student
        public Student(string name, EntitySex sex, int strength, int speed, int health, int intelligence) : base()
        {
            //Add formulas for genderating stats
            //Base those formulas on the Class
            _name = name;
            _sex = sex;
            _strength = strength;
            _speed = speed;
            _health = health;
            _intelligence = intelligence;
        }

    }
}
