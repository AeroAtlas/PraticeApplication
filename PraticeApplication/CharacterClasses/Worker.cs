using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeApplication.CharacterClasses
{
    class Worker : Entity
    {

        public Worker() : base()
        {
        }

        //Create the specific student
        public Worker(string name, EntitySex sex) : base()
        {
            //Add formulas for genderating stats
            //Base those formulas on the Class
            Name = name;
            Sex = sex;
            _strength = rand.Next(4, 8);
        }
    }
}
