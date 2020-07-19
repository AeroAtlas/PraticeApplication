using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeApplication.CharacterClasses
{
    public enum EntitySex { Male, Female, Unknown }
    public enum EntityClass { Student, Worker, Cop, Criminal, Unknown }

    public abstract class Entity
    {
        #region Fields Region
        //Add a random Geenerator
        protected Random rand = new Random();

        //Add stat variables
        protected string _name;
        protected EntitySex _sex;
        protected EntityClass _characterClass;
        protected int _strength, _speed, _health, _intelligence;
        protected int _strengthModifier, _speedModifier, _healthModifier, _intelligenceModifier;
        #endregion
        //can add AttributePair to stats also consider adding xp, damage, defense, level, etc
        #region Properties Region
        public string Name
        {
            get { return _name; } //Returns name
            set { _name = value; } //Lets them change name
        } 
        public EntitySex Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        public EntityClass CharacterClass
        {
            get { return _characterClass; }
            set { _characterClass = value; }
        }
        public int Strength
        {
            get { return _strength + _strengthModifier; }
            set { _strength = value; }
        }
        public int Speed
        {
            get { return _speed + _speedModifier; }
            set { _speed = value; }
        }
        public int Health
        {
            get { return _health + _healthModifier; }
            set { _health = value; }
        }
        public int Intelligence
        {
            get { return _intelligence + _intelligenceModifier; }
            set { _intelligence = value; }
        }

        #endregion

        #region Constructor Region
        public Entity()
        {
            Name = "";
            Sex = EntitySex.Unknown;
            CharacterClass = EntityClass.Unknown;
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
