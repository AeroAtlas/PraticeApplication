using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeApplication.CharacterClasses
{
    public enum EntitySex { Male, Female, Unknown }

    public abstract class Entity
    {
        #region Fields Region
        //Add a random Geenerator
        protected Random rand;

        //Add stat variables
        protected string _name;
        protected EntitySex _sex;
        protected int _strength, _speed, _health, _intelligence;
        protected int _strengthModifier, _speedModifier, _healthModifier, _intelligenceModifier;
        #endregion
        //can add AttributePair to stats also consider adding xp, damage, defense, level, etc
        #region Properties Region
        public string Name
        {
            get { return _name; } //Returns name
            protected set { _name = value; } //Lets them change name
        } 
        public EntitySex Sex
        {
            get { return _sex; }
            protected set { _sex = value; }
        }
        public int Strength
        {
            get { return _strength + _strengthModifier; }
            protected set { _strength = value; }
        }
        public int Speed
        {
            get { return _speed + _speedModifier; }
            protected set { _speed = value; }
        }
        public int Health
        {
            get { return _health + _healthModifier; }
            protected set { _health = value; }
        }
        public int Intelligence
        {
            get { return _intelligence + _intelligenceModifier; }
            protected set { _intelligence = value; }
        }

        #endregion

        #region Constructor Region
        public Entity()
        {
            Name = "";
            Strength = 0;
            Speed = 0;
            Health = 0;
            Intelligence = 0;
        }
        #endregion

        #region Methods Region

        #endregion
    }
}
