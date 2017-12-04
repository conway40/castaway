using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// the character class the player uses in the game
    /// </summary>
    public class Survivor : Character
    {
        #region ENUMERABLES

        public enum EthnicityType
        {
            None,
            White,
            Black,
            Asian,
            Native,
            Hispanic
        }

        #endregion

        #region FIELDS

        private EthnicityType _ethnicity;
        private int _experiencePoints;
        private int _health;
        private int _lives;
        private List<int> _islandLocationsVisited;
		private List<SurvivorObject> _inventory;

        #endregion

        #region PROPERTIES

        public EthnicityType Ethnicity
        {
            get { return _ethnicity; }
            set { _ethnicity = value; }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set { _experiencePoints = value; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }

        public List<int> IslandLocationsVisisted
        {
            get { return _islandLocationsVisited; }
            set { _islandLocationsVisited = value; }
        }

		public List<SurvivorObject> Inventory
		{
			get { return _inventory; }
			set { _inventory = value; }
		}

		#endregion

		#region CONSTRUCTORS

		public Survivor()
        {
            _islandLocationsVisited = new List<int>();
			_inventory = new List<SurvivorObject>();
        }

        public Survivor(string name, AnimalType animal, int islandLocationID) : base(name, animal, islandLocationID)
        {
            _islandLocationsVisited = new List<int>();
			_inventory = new List<SurvivorObject>();
		}

        #endregion

        #region METHODS

        public override AnimalType SetAnimal()
        {
            return this.Animal = AnimalType.Human;
        }

        public bool HasVisited(int _islandLocationID)
        {
            if (IslandLocationsVisisted.Contains(_islandLocationID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
