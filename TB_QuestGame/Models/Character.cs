using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// base class for the player and all game characters
    /// </summary>
    public class Character
    {
        #region ENUMERABLES

        public enum AnimalType
        {
            None,
            Human,
            Monkey,
            Parrot
        }

        #endregion

        #region FIELDS

        private string _name;
        private int _islandLocationID;
        private int _age;
        private bool _isLiving;
        private AnimalType _animal;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int IslandLocationID
        {
            get { return _islandLocationID; }
            set { _islandLocationID = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public bool IsLiving
        {
            get { return _isLiving; }
            set { _isLiving = value; }
        }

        public AnimalType Animal
        {
            get { return _animal; }
            set { _animal = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, AnimalType animal, int islandLocationID)
        {
            _name = name;
            _animal = animal;
            _islandLocationID = islandLocationID;
        }

        #endregion

        #region METHODS

        public virtual AnimalType SetAnimal()
        {
            return this.Animal = AnimalType.None;
        }

        #endregion
    }
}
