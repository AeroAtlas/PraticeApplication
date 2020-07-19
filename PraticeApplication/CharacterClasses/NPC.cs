using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeApplication.CharacterClasses
{
    class NPC : Entity
    {
        Random rand = new Random();

        public NPC() : base()
        {

        }

        public NPC(string name, EntitySex eSex, EntityClass eClass) : base()
        {
            Name = name;
            Sex = eSex;
            CharacterClass = eClass;
        }
    }
}
