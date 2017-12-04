using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// controller for the MVC pattern in the application
    /// </summary>
    public class Controller
    {
        #region FIELDS

        private ConsoleView _gameConsoleView;
        private Survivor _gameSurvivor;
        private Universe _gameUniverse;
        private bool _playingGame;
        private IslandLocation _currentLocation;

        #endregion

        #region PROPERTIES


        #endregion

        #region CONSTRUCTORS

        public Controller()
        {
            //
            // setup all of the objects in the game
            //
            InitializeGame();

            //
            // begins running the application UI
            //
            ManageGameLoop();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// initialize the major game objects
        /// </summary>
        private void InitializeGame()
        {
            _gameSurvivor = new Survivor();
            _gameUniverse = new Universe();
            _gameConsoleView = new ConsoleView(_gameSurvivor, _gameUniverse);
            _playingGame = true;

			//
			// add initial items to the traveler's inventory
			//
			_gameSurvivor.Inventory.Add(_gameUniverse.GetGameObjectById(1) as SurvivorObject);
			_gameSurvivor.Inventory.Add(_gameUniverse.GetGameObjectById(2) as SurvivorObject);

			Console.CursorVisible = false;
        }

        /// <summary>
        /// method to manage the application setup and game loop
        /// </summary>
        private void ManageGameLoop()
        {
            SurvivorAction survivorActionChoice = SurvivorAction.None;

            //
            // display splash screen
            //
            _playingGame = _gameConsoleView.DisplaySpashScreen();

            //
            // player chooses to quit
            //
            if (!_playingGame)
            {
                Environment.Exit(1);
            }

            //
            // display introductory message
            //
            _gameConsoleView.DisplayGamePlayScreen("Quest Intro", Text.QuestIntro(), ActionMenu.QuestIntro, "");
            _gameConsoleView.GetContinueKey();

            //
            // initialize the mission traveler
            // 
            InitializeMission();

            //
            // prepare game play screen
            //
            _currentLocation = _gameUniverse.GetIslandLocationById(_gameSurvivor.IslandLocationID);
            _gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrentLocationInfo(_gameUniverse.GetIslandLocationById(_gameSurvivor.IslandLocationID)), ActionMenu.MainMenu, "");

            //
            // game loop
            //
            while (_playingGame)
            {
                //
                // process all flags, events, and stats
                //
                UpdateGameStatus(_playingGame);

                //
                // get next game action from player
                //
                survivorActionChoice = GetNextTravelerAction();

                //
                // choose an action based on the user's menu choice
                //
                switch (survivorActionChoice)
                {
                    case SurvivorAction.None:
                        break;

                    case SurvivorAction.SurvivorInfo:
                        _gameConsoleView.DisplaySurvivorInfo();
                        break;

                    case SurvivorAction.SurvivorEditInfo:
                        _gameConsoleView.EditSurvivorInfo(_gameSurvivor);
                        break;

                    case SurvivorAction.LookAround:
                        _gameConsoleView.DisplayLookAround();
                        break;

					case SurvivorAction.LookAt:
						LookAtAction();
						break;

                    case SurvivorAction.PickUp:
                        PickUpAction();
                        break;

                    case SurvivorAction.PutDown:
                        PutDownAction();
                        break;

                    case SurvivorAction.InteractWith:
                        InteractWithAction();
                        break;

					case SurvivorAction.Inventory:
						_gameConsoleView.DisplayInventory();
						break;

                    case SurvivorAction.Travel:
                        //
                        // get new location choice and update the current location property
                        //                        
                        _gameSurvivor.IslandLocationID = _gameConsoleView.DisplayGetNextIslandLocation();
                        _currentLocation = _gameUniverse.GetIslandLocationById(_gameSurvivor.IslandLocationID);

                        //
                        // set the game play screen to the current location info format
                        //
                        _gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrentLocationInfo(_currentLocation), ActionMenu.MainMenu, "");

                        UpdateGameStatus(_playingGame);
                        break;

                    case SurvivorAction.SurvivorLocationsVisited:
                        _gameConsoleView.DisplayLocationsVisited();
                        break;

                    case SurvivorAction.ListIslandLocations:
                        _gameConsoleView.DisplayListOfIslandLocations();
                        break;

					case SurvivorAction.ListGameObjects:
						_gameConsoleView.DisplayListOfAllGameObjects();
						break;

                    case SurvivorAction.ListNonplayerCharacters:
                        _gameConsoleView.DisplayListOfAllNpcObjects();
                        break;

                    case SurvivorAction.SurvivorMenu:
                        ActionMenu.currentMenu = ActionMenu.CurrentMenu.TravelerMenu;
                        _gameConsoleView.DisplayGamePlayScreen("Traveler Menu", "Select an operation from the menu.", ActionMenu.SurvivorMenu, "");
                        break;

                    case SurvivorAction.ObjectMenu:
                        ActionMenu.currentMenu = ActionMenu.CurrentMenu.ObjectMenu;
                        _gameConsoleView.DisplayGamePlayScreen("Object Menu", "Select an operation from the menu.", ActionMenu.ObjectMenu, "");
                        break;

                    case SurvivorAction.NonplayerCharacterMenu:
                        ActionMenu.currentMenu = ActionMenu.CurrentMenu.NpcMenu;
                        _gameConsoleView.DisplayGamePlayScreen("NPC Menu", "Select an operation from the menu.", ActionMenu.NpcMenu, "");
                        break;

                    case SurvivorAction.TalkTo:
                        TalkToAction();
                        break;

                    case SurvivorAction.AskToScavenge:
                        AskToScavenge();
                        break;

                    case SurvivorAction.AdminMenu:
						ActionMenu.currentMenu = ActionMenu.CurrentMenu.AdminMenu;
						_gameConsoleView.DisplayGamePlayScreen("Admin Menu", "Select an operation from the menu.", ActionMenu.AdminMenu, "");
						break;

					case SurvivorAction.ReturnToMainMenu:
						ActionMenu.currentMenu = ActionMenu.CurrentMenu.MainMenu;
						_gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrentLocationInfo(_currentLocation), ActionMenu.MainMenu, "");
						break;

					case SurvivorAction.Exit:
                        _playingGame = false;
                        break;

                    default:
                        break;
                }
            }

            //
            // close the application
            //
            Environment.Exit(1);
        }

        /// <summary>
        /// initialize the player info
        /// </summary>
        private void InitializeMission()
        {
            Survivor traveler = _gameConsoleView.GetInitialSurvivorInfo();

            _gameSurvivor.Name = traveler.Name;
            _gameSurvivor.Age = traveler.Age;
            _gameSurvivor.Ethnicity = traveler.Ethnicity;
            _gameSurvivor.IslandLocationID = 1;

            _gameSurvivor.ExperiencePoints = 0;
            _gameSurvivor.Health = 100;
            _gameSurvivor.Lives = 3;
        }

        private void UpdateGameStatus(bool _playingGame)
        {
            if (!_gameSurvivor.HasVisited(_currentLocation.IslandLocationID))
            {
                //
                // add new location to the list of visited locations if this is a first visit
                //
                _gameSurvivor.IslandLocationsVisisted.Add(_currentLocation.IslandLocationID);

                //
                // update experience points for visiting locations
                //
                _gameSurvivor.ExperiencePoints += _currentLocation.ExperiencePoints;
            }

            //
            // if they have both parts of the radio, they win the game
            //
            if(_gameSurvivor.Inventory.Contains(_gameUniverse.GetGameObjectById(75)) && _gameSurvivor.Inventory.Contains(_gameUniverse.GetGameObjectById(79)))
            {
                _gameConsoleView.DisplayGameWon();
                _playingGame = false;
                Environment.Exit(1);
            }

            //
            // update location accessiblity
            //
            if (_currentLocation.IslandLocationID == 1)
            {
                _gameUniverse.GetIslandLocationById(1).Accessible = true;
                _gameUniverse.GetIslandLocationById(2).Accessible = true;
                _gameUniverse.GetIslandLocationById(3).Accessible = false;
                _gameUniverse.GetIslandLocationById(4).Accessible = false;
                _gameUniverse.GetIslandLocationById(5).Accessible = false;
                _gameUniverse.GetIslandLocationById(6).Accessible = false;
                _gameUniverse.GetIslandLocationById(7).Accessible = false;
            }
            else if (_currentLocation.IslandLocationID == 2)
            {
                _gameUniverse.GetIslandLocationById(1).Accessible = true;
                _gameUniverse.GetIslandLocationById(2).Accessible = true;
                _gameUniverse.GetIslandLocationById(3).Accessible = true;
                _gameUniverse.GetIslandLocationById(4).Accessible = true;
                _gameUniverse.GetIslandLocationById(5).Accessible = false;
                _gameUniverse.GetIslandLocationById(6).Accessible = false;
                _gameUniverse.GetIslandLocationById(7).Accessible = false;
            }
            else if (_currentLocation.IslandLocationID == 3)
            {
                _gameUniverse.GetIslandLocationById(1).Accessible = false;
                _gameUniverse.GetIslandLocationById(2).Accessible = true;
                _gameUniverse.GetIslandLocationById(3).Accessible = true;
                _gameUniverse.GetIslandLocationById(4).Accessible = false;
                _gameUniverse.GetIslandLocationById(5).Accessible = true;
                _gameUniverse.GetIslandLocationById(6).Accessible = false;
                _gameUniverse.GetIslandLocationById(7).Accessible = false;
            }
            else if (_currentLocation.IslandLocationID == 4)
            {
                _gameUniverse.GetIslandLocationById(1).Accessible = false;
                _gameUniverse.GetIslandLocationById(2).Accessible = true;
                _gameUniverse.GetIslandLocationById(3).Accessible = false;
                _gameUniverse.GetIslandLocationById(4).Accessible = true;
                _gameUniverse.GetIslandLocationById(5).Accessible = false;
                _gameUniverse.GetIslandLocationById(6).Accessible = false;
                _gameUniverse.GetIslandLocationById(7).Accessible = false;
            }
            else if (_currentLocation.IslandLocationID == 5)
            {
                _gameUniverse.GetIslandLocationById(1).Accessible = false;
                _gameUniverse.GetIslandLocationById(2).Accessible = false;
                _gameUniverse.GetIslandLocationById(3).Accessible = true;
                _gameUniverse.GetIslandLocationById(4).Accessible = false;
                _gameUniverse.GetIslandLocationById(5).Accessible = true;
                _gameUniverse.GetIslandLocationById(6).Accessible = true;
                _gameUniverse.GetIslandLocationById(7).Accessible = false;
            }
            else if (_currentLocation.IslandLocationID == 6)
            {
                _gameUniverse.GetIslandLocationById(1).Accessible = false;
                _gameUniverse.GetIslandLocationById(2).Accessible = false;
                _gameUniverse.GetIslandLocationById(3).Accessible = false;
                _gameUniverse.GetIslandLocationById(4).Accessible = false;
                _gameUniverse.GetIslandLocationById(5).Accessible = true;
                _gameUniverse.GetIslandLocationById(6).Accessible = true;
                _gameUniverse.GetIslandLocationById(7).Accessible = true;
            }
            else if (_currentLocation.IslandLocationID == 7)
            {
                _gameUniverse.GetIslandLocationById(1).Accessible = false;
                _gameUniverse.GetIslandLocationById(2).Accessible = false;
                _gameUniverse.GetIslandLocationById(3).Accessible = false;
                _gameUniverse.GetIslandLocationById(4).Accessible = false;
                _gameUniverse.GetIslandLocationById(5).Accessible = false;
                _gameUniverse.GetIslandLocationById(6).Accessible = true;
                _gameUniverse.GetIslandLocationById(7).Accessible = true;
            }
        }

		private void LookAtAction()
		{
			//
			// display a list of traveler objects in space-time location and get a player choice
			//
			int gameObjectToLookAtId = _gameConsoleView.DisplayGetGameObjectToLookAt();

			//
			// display game object info
			//
			if (gameObjectToLookAtId != 0)
			{
				//
				// get the game object from the universe
				//
				GameObject gameObject = _gameUniverse.GetGameObjectById(gameObjectToLookAtId);

				//
				// display information for the object chosen
				//
				_gameConsoleView.DisplayGameObjectInfo(gameObject);
			}
		}

        private void PickUpAction()
        {
            //
            // display a list of survivor object in island location and get a player choice
            //
            int survivorObjectToPickUpId = _gameConsoleView.DisplayGetSurvivorObjectToPickUp();

            //
            // add the survivor object to survivor's inventory
            //
            if (survivorObjectToPickUpId != 0)
            {
                //
                // get the game object from the universe
                //
                SurvivorObject survivorObject = _gameUniverse.GetGameObjectById(survivorObjectToPickUpId) as SurvivorObject;

                //
                // note: survivor object is added to list and the island location is set to 0
                //
                _gameSurvivor.Inventory.Add(survivorObject);
                survivorObject.IslandLocationId = 0;

                //
                // update experience points, health, and lives
                //
                _gameSurvivor.ExperiencePoints += survivorObject.ExperiencePoints;
                _gameSurvivor.Health += survivorObject.HealthPoints;
                _gameSurvivor.Lives += survivorObject.Lives;

                //
                // display confirmation message
                //
                _gameConsoleView.DisplayConfirmSurvivorObjectAddedToInventory(survivorObject);
            }
        }

        private void PutDownAction()
        {
            //
            // display a list of survivor objects in inventory and get a player choice
            //
            int inventoryObjectToPutDownId = _gameConsoleView.DisplayGetInventoryObjectToPutDown();

            //
            // get the game object from the universe
            //
            SurvivorObject survivorObject = _gameUniverse.GetGameObjectById(inventoryObjectToPutDownId) as SurvivorObject;

            //
            // remove the object from inventory and set the island location to the current value
            // 
            _gameSurvivor.Inventory.Remove(survivorObject);
            survivorObject.IslandLocationId = _gameSurvivor.IslandLocationID;

            //
            // display confirmation message
            //
            _gameConsoleView.DisplayConfirmSurvivorObjectRemovedFromInventory(survivorObject);
        }

        private void InteractWithAction()
        {
            //
            // display a list of interactive objects in location, if any, and get a player choice
            //
            int objectToInteractWithId = _gameConsoleView.DisplayGetObjectToInteractWithId();

            if (objectToInteractWithId != 0)
            {
                //
                // get the game object from the universe
                //
                InteractiveObject interactiveObject = _gameUniverse.GetGameObjectById(objectToInteractWithId) as InteractiveObject;

                //
                // different interactions based on item
                // 
                switch (interactiveObject.Type)
                {
                    case InteractiveObjectType.WaterBody:
                        // fish, bathe, or dive
                        string waterInteraction = _gameConsoleView.GetWaterBodyInteraction();
                        if (waterInteraction == "fish")
                        {
                            FishAction();
                        }
                        else if (waterInteraction == "bathe")
                        {
                            BatheAction();
                        }
                        //else if (waterInteraction == "dive")
                        //{
                        //    DiveAction();
                        //}
                        break;
                    //case InteractiveObjectType.Workbench:
                    //    // craft items based on inventory items (use bool)
                    //    WorkbenchAction();
                    //    break;
                    //case InteractiveObjectType.Pier:
                    //    // repair pier based on inventory items (use bool)
                    //    PierAction();
                    //    break;
                    //case InteractiveObjectType.Ship:
                    //    // find objects within
                    //    ShipAction();
                    //    break;
                    //case InteractiveObjectType.Firepit:
                    //    // craft fire based on inventory items (use bool)
                    //    FirepitAction();
                    //    break;
                    //case InteractiveObjectType.TreasureChest:
                    //    // get treasure within
                    //    TreasureChestAction();
                    //break;
                    default:
                        break;
                }
            }
            
        }

        #region InteractiveObjects Actions

        private void FishAction()
        {
            // get location
            int location = _gameSurvivor.IslandLocationID;
            // get fish in that location, if any
            List<SurvivorObject> fishesInLocation = new List<SurvivorObject>();
            List<GameObject> objectsInLocation = _gameUniverse.GetGameObjectsByIslandLocationId(location);

            foreach (GameObject gameObject in objectsInLocation)
            {
                if (gameObject is SurvivorObject)
                {
                    SurvivorObject survivorObject = gameObject as SurvivorObject;
                    if (survivorObject.Type == SurvivorObjectType.Fish)
                    {
                        fishesInLocation.Add(survivorObject);
                    }
                }
                
            }
            // randomly chose a fish
            if (fishesInLocation.Count() != 0)
            {
                int numOfFishes = fishesInLocation.Count();
                int fishId;

                if (numOfFishes > 1)
                {
                    Random rnd = new Random();
                    fishId = rnd.Next(1, numOfFishes);
                }
                else
                {
                    fishId = 0;
                }

                SurvivorObject caughtFish = _gameUniverse.GetGameObjectById(fishesInLocation[fishId].Id) as SurvivorObject;

                //
                // note: survivor object is added to list and the island location is set to 0
                //
                _gameSurvivor.Inventory.Add(caughtFish);
                caughtFish.IslandLocationId = 0;

                //
                // update experience points, health, and lives
                //
                _gameSurvivor.ExperiencePoints += caughtFish.ExperiencePoints;
                _gameSurvivor.Health += caughtFish.HealthPoints;
                _gameSurvivor.Lives += caughtFish.Lives;

                //
                // display confirmation message
                //
                _gameConsoleView.DisplayConfirmSurvivorObjectAddedToInventory(caughtFish);
            }
            else if (fishesInLocation.Count() == 0)
            {
                _gameConsoleView.DisplayFishingErrorMessage();
            }
        }

        private void BatheAction()
        {
            // add health points
            int bathingHealthPoints = 10;
            if (_gameSurvivor.Health > 100)
            {
                _gameSurvivor.Health += bathingHealthPoints;
                _gameConsoleView.DisplayBathingMessage(bathingHealthPoints);
            }
            else
            {
                _gameConsoleView.DisplayBathingMessage(0);
            }
            
        }
        //private void DiveAction()
        //{
        //     get dive objects and choose a random one
        //}
        //private void WorkbenchAction()
        //{
        //    // make CraftedItems based on inventory items

        //    // chisel

        //    // knife

        //    // fishing spear

        //    // axe

        //    // canoe

        //    // assembled radio
        //}
        //private void PierAction()
        //{
        //    // rebuild pier based on inventory items
        //}
        //private void ShipAction()
        //{
        //    // get ship objects and choose a random one
        //}
        //private void FirepitAction()
        //{
        //    // build fire based on inventory items
        //}
        //private void TreasureChestAction()
        //{
        //    // give radio transmitter
        //}

        #endregion

        /// <summary>
        /// display the correct menu/sub-menu and get the next traveler action
        /// </summary>
        /// <returns>traveler action</returns>
        private SurvivorAction GetNextTravelerAction()
        {
            SurvivorAction survivorActionChoice = SurvivorAction.None;

            switch (ActionMenu.currentMenu)
            {
                case ActionMenu.CurrentMenu.MainMenu:
                    survivorActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.MainMenu);
                    break;

                case ActionMenu.CurrentMenu.ObjectMenu:
                    survivorActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.ObjectMenu);
                    break;

                case ActionMenu.CurrentMenu.NpcMenu:
                    survivorActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.NpcMenu);
                    break;

                case ActionMenu.CurrentMenu.TravelerMenu:
                    survivorActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.SurvivorMenu);
                    break;

                case ActionMenu.CurrentMenu.AdminMenu:
                    survivorActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.AdminMenu);
                    break;

                default:
                    break;
            }

            return survivorActionChoice;
        }

        private void TalkToAction()
        {
            //
            // display a list of NPCs in space-time location and get a player choice
            //
            int npcToTalkToId = _gameConsoleView.DisplayGetNpcToTalkTo();

            //
            // display NPC's message
            //
            if (npcToTalkToId != 0)
            {
                //
                // get the NPC from the universe
                //
                Npc npc = _gameUniverse.GetNpcById(npcToTalkToId);

                //
                // display information for the object chosen
                //
                _gameConsoleView.DisplayTalkTo(npc);

                //
                // add experience points, lives, health
                //
                CrewMember theNpc = _gameUniverse.GetNpcById(npcToTalkToId) as CrewMember;

                _gameSurvivor.ExperiencePoints += theNpc.ExperiencePoints;
                _gameSurvivor.Health += theNpc.Health;
                _gameSurvivor.Lives += theNpc.Lives;

                //
                // unlock location if npc has a key
                //
                UnlockLocation(theNpc);
            }
        }

        private void UnlockLocation(CrewMember civilian)
        {
            int keys = civilian.Keys;

            if (keys != 0)
            {
                IslandLocation unlockedLocation = _gameUniverse.GetIslandLocationById(keys);
                unlockedLocation.Accessible = true;
            }
        }

        #endregion
    }
}
