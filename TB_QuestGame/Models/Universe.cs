using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TB_QuestGame;

namespace TB_QuestGame
{
    /// <summary>
    /// class of the game map
    /// </summary>
    public class Universe
    {
		#region ***** define all lists to be maintained by the Universe object *****

		//
		// list of all island locations and game objects
		//
		private List<IslandLocation> _islandLocations;
		private List<GameObject> _gameObjects;
        private List<Npc> _npcs;

        public List<IslandLocation> IslandLocations
		{
			get { return _islandLocations; }
			set { _islandLocations = value; }
		}

		public List<GameObject> GameObjects
		{
			get { return _gameObjects; }
			set { _gameObjects = value; }
		}

        public List<Npc> Npcs
        {
            get { return _npcs; }
            set { _npcs = value; }
        }

        #endregion

        #region ***** constructor *****

        //
        // default Universe constructor
        //
        public Universe()
        {
            //
            // add all of the universe objects to the game
            // 
            IntializeUniverse();
        }

        #endregion

        #region ***** define methods to initialize all game elements *****

        /// <summary>
        /// initialize the universe with all of the island locations
        /// </summary>
        private void IntializeUniverse()
        {
            _islandLocations = UniverseObjects.IslandLocations;
			_gameObjects = UniverseObjects.gameObjects;
            _npcs = UniverseObjects.Npcs;
        }

        #endregion

        #region ***** define methods to return game element objects and information *****

        /// <summary>
        /// determine if the Space-Time Location Id is valid
        /// </summary>
        /// <param name="islandLocationId">true if Space-Time Location exists</param>
        /// <returns></returns>
        public bool IsValidIslandLocationId(int islandLocationId)
        {
            List<int> islandLocationIds = new List<int>();

            //
            // create a list of island location ids
            //
            foreach (IslandLocation stl in _islandLocations)
            {
                islandLocationIds.Add(stl.IslandLocationID);
            }

            //
            // determine if the island location id is a valid id and return the result
            //
            if (islandLocationIds.Contains(islandLocationId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		public bool IsValidGameObjectByLocationId(int gameObjectId, int currentIslandLocation)
		{
			List<int> gameObjectIds = new List<int>();

			//
			// create a list of game onject ids in current space-time location
			//
			foreach (GameObject gameObject in _gameObjects)
			{
				if (gameObject.IslandLocationId == currentIslandLocation)
				{
					gameObjectIds.Add(gameObject.Id);
				}
			}

			//
			// determine if the game object id is a valid id and return the result
			//
			if (gameObjectIds.Contains(gameObjectId))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// determine if a location is accessible to the player
		/// </summary>
		/// <param name="islandLocationId"></param>
		/// <returns>accessible</returns>
		public bool IsAccessibleLocation(int islandLocationId)
        {
            IslandLocation islandLocation = GetIslandLocationById(islandLocationId);
            if (islandLocation.Accessible == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// return the next available ID for a IslandLocation object
        /// </summary>
        /// <returns>next IslandLocationObjectID </returns>
        public int GetMaxIslandLocationId()
        {
            int MaxId = 0;

            foreach (IslandLocation islandLocation in IslandLocations)
            {
                if (islandLocation.IslandLocationID > MaxId)
                {
                    MaxId = islandLocation.IslandLocationID;
                }
            }

            return MaxId;
        }

        /// <summary>
        /// get a SpaceTimeLocation object using an Id
        /// </summary>
        /// <param name="Id">space-time location ID</param>
        /// <returns>requested space-time location</returns>
        public IslandLocation GetIslandLocationById(int Id)
        {
            IslandLocation islandLocation = null;

            //
            // run through the island location list and grab the correct one
            //
            foreach (IslandLocation location in _islandLocations)
            {
                if (location.IslandLocationID == Id)
                {
                    islandLocation = location;
                }
            }

            //
            // the specified ID was not found in the universe
            // throw an exception
            //
            if (islandLocation == null)
            {
                string feedbackMessage = $"The Island Location ID {Id} does not exist in the current Universe.";
                throw new ArgumentException(Id.ToString(), feedbackMessage);
            }

            return islandLocation;
        }

		public GameObject GetGameObjectById(int Id)
		{
			GameObject gameObjectToReturn = null;

			//
			// run through the game object list and grab the correct one
			//
			foreach (GameObject gameObject in _gameObjects)
			{
				if (gameObject.Id == Id)
				{
					gameObjectToReturn = gameObject;
				}
			}

			//
			// the specified ID was not found in the universe
			// throw an exception
			//
			if (gameObjectToReturn == null)
			{
				string feedbackMessage = $"The Game Object ID {Id} does not exist in the current universe.";
				throw new ArgumentException(feedbackMessage, Id.ToString());
			}

			return gameObjectToReturn;
		}

		public List<GameObject> GetGameObjectsByIslandLocationId(int islandLocationId)
		{
			List<GameObject> gameObjects = new List<GameObject>();

			//
			// run through the game object list and grab all that are in the current space-time location
			//
			foreach (GameObject gameObject in _gameObjects)
			{
				if (gameObject.IslandLocationId == islandLocationId)
				{
					gameObjects.Add(gameObject);
				}
			}

			return gameObjects;
		}

        public List<InteractiveObject> GetInteractiveObjectsByIslandLocationId(int islandLocationId)
        {
            List<InteractiveObject> interactiveObjects = new List<InteractiveObject>();

            //
            // run through the game object list and grab all that are in the current space-time location
            //
            foreach (GameObject gameObject in _gameObjects)
            {
                if (gameObject.IslandLocationId == islandLocationId && gameObject is InteractiveObject)
                {
                    interactiveObjects.Add(gameObject as InteractiveObject);
                }
            }

            return interactiveObjects;
        }

        public bool IsValidSurvivorObjectByLocationId(int survivorObjectId, int currentIslandLocation)
        {
            List<int> survivorObjectIds = new List<int>();

            //
            // create a list of survivor object ids in current island locaiton
            //
            foreach (GameObject gameObject in _gameObjects)
            {
                if (gameObject.IslandLocationId == currentIslandLocation && gameObject is SurvivorObject)
                {
                    survivorObjectIds.Add(gameObject.Id);
                }
            }

            //
            // determine if the game id is a valid id and return the result
            //
            if (survivorObjectIds.Contains(survivorObjectId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<SurvivorObject> GetSurvivorObjectsByIslandLocationId(int islandLocationId)
        {
            List<SurvivorObject> survivorObjects = new List<SurvivorObject>();

            //
            // run through the game object list and grab all that are in the current space-time location
            //
            foreach (GameObject gameObject in _gameObjects)
            {
                if (gameObject.IslandLocationId == islandLocationId && gameObject is SurvivorObject)
                {
                    survivorObjects.Add(gameObject as SurvivorObject);
                }
            }

            return survivorObjects;
        }

        public bool IsValidNpcByLocationId(int npcId, int currentSpaceTimeLocation)
        {
            List<int> npcIds = new List<int>();

            //
            // create a list of NPC ids in current space-time location
            //
            foreach (Npc npc in _npcs)
            {
                if (npc.IslandLocationID == currentSpaceTimeLocation)
                {
                    npcIds.Add(npc.Id);
                }
            }

            //
            // determine if the NPC id is a valid id and return the resulf
            //
            if (npcIds.Contains(npcId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Npc GetNpcById(int Id)
        {
            Npc npcToReturn = null;

            //
            // run through the NPC object list and grab the correct one
            //
            foreach (Npc npc in _npcs)
            {
                if (npc.Id == Id)
                {
                    npcToReturn = npc;
                }
            }

            //
            // the specified Id was not found in the universe
            // throw an exception
            //
            if (npcToReturn == null)
            {
                string feedbackMessage = $"The NPC ID {Id} does not exist in the current universe.";
                throw new ArgumentException(feedbackMessage, Id.ToString());
            }

            return npcToReturn;
        }

        public List<Npc> GetNpcsBySpaceTimeLocationId(int spaceTimeLocationId)
        {
            List<Npc> npcs = new List<Npc>();

            //
            // run through the NPC object list and grab all that are in the current space-time location
            //
            foreach (Npc npc in _npcs)
            {
                if (npc.IslandLocationID == spaceTimeLocationId)
                {
                    npcs.Add(npc);
                }
            }

            return npcs;
        }

        #endregion
    }
}
