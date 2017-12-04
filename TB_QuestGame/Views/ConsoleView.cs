using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// view class
    /// </summary>
    public class ConsoleView
    {
        #region ENUMS

        private enum ViewStatus
        {
            SurvivorInitialization,
            PlayingGame
        }

        #endregion

        #region FIELDS

        //
        // declare game objects for the ConsoleView object to use
        //
        Survivor _gameSurvivor;
        Universe _gameUniverse;

        ViewStatus _viewStatus;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// default constructor to create the console view objects
        /// </summary>
        public ConsoleView(Survivor gameSurvivor, Universe gameUniverse)
        {
            _gameSurvivor = gameSurvivor;
            _gameUniverse = gameUniverse;

            _viewStatus = ViewStatus.SurvivorInitialization;

            InitializeDisplay();
        }

        #endregion

        #region METHODS
        /// <summary>
        /// display all of the elements on the game play screen on the console
        /// </summary>
        /// <param name="messageBoxHeaderText">message box header title</param>
        /// <param name="messageBoxText">message box text</param>
        /// <param name="menu">menu to use</param>
        /// <param name="inputBoxPrompt">input box text</param>
        public void DisplayGamePlayScreen(string messageBoxHeaderText, string messageBoxText, Menu menu, string inputBoxPrompt)
        {
            //
            // reset screen to default window colors
            //
            Console.BackgroundColor = ConsoleTheme.WindowBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.WindowForegroundColor;
            Console.Clear();

            ConsoleWindowHelper.DisplayHeader(Text.HeaderText);
            ConsoleWindowHelper.DisplayFooter(Text.FooterText);

            DisplayMessageBox(messageBoxHeaderText, messageBoxText);
            DisplayMenuBox(menu);
            DisplayInputBox();
            DisplayStatusBox();
        }

        /// <summary>
        /// wait for any keystroke to continue
        /// </summary>
        public void GetContinueKey()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// get a action menu choice from the user
        /// </summary>
        /// <returns>action menu choice</returns>
        public SurvivorAction GetActionMenuChoice(Menu menu)
        {
            SurvivorAction choosenAction = SurvivorAction.None;
            Console.CursorVisible = false;

            //
            // create an array of valid keys from menu dictionary
            //
            char[] validKeys = menu.MenuChoices.Keys.ToArray();

            //
            // validate key pressed as in MenuChoices dictionary
            //
            char keyPressed;
            do
            {
                ConsoleKeyInfo keyPressedInfo = Console.ReadKey(true);
                keyPressed = keyPressedInfo.KeyChar;
            } while (!validKeys.Contains(keyPressed));

            choosenAction = menu.MenuChoices[keyPressed];
            Console.CursorVisible = true;

            return choosenAction;
        }

        /// <summary>
        /// get a string value from the user
        /// </summary>
        /// <returns>string value</returns>
        public string GetString()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// get an integer value from the user
        /// </summary>
        /// <returns>integer value</returns>
        public bool GetInteger(string prompt, int minimumValue, int maximumValue, out int integerChoice)
        {
			bool validResponse = false;
			integerChoice = 0;

			//
			// validate on range if either minimumValue and maxiumumValue are not 0
			//
			bool validateRange = (minimumValue != 0 || maximumValue != 0);

			DisplayInputBoxPrompt(prompt);
			while (!validResponse)
			{
				if (int.TryParse(Console.ReadLine(), out integerChoice))
				{
					if (validateRange)
					{
						if (integerChoice >= minimumValue && integerChoice <= maximumValue)
						{
							validResponse = true;
						}
						else
						{
							ClearInputBox();
							DisplayInputErrorMessage($"You must enter an integer value between {minimumValue} and {maximumValue}. Please try again.");
							DisplayInputBoxPrompt(prompt);
						}
					}
					else
					{
						validResponse = true;
					}
				}
				else
				{
					ClearInputBox();
					DisplayInputErrorMessage($"You must enter an integer value. Please try again.");
					DisplayInputBoxPrompt(prompt);
				}
			}

			Console.CursorVisible = false;

			return true;
		}

		/// <summary>
		/// Capitalizes the first letter of a string
		/// </summary>
		public string CapitalizeFirstLetter(string s)
        {
            if (String.IsNullOrEmpty(s))
                return s;
            if (s.Length == 1)
                return s.ToUpper();
            return s.Remove(1).ToUpper() + s.Substring(1);
        }

        /// <summary>
        /// get a character race value from the user
        /// </summary>
        /// <returns>character race value</returns>
        public Survivor.EthnicityType GetRace()
        {
            bool isValid = false;
            Survivor.EthnicityType raceType = Survivor.EthnicityType.None;

            while (!isValid)
            {
                
                string userResponse = CapitalizeFirstLetter(Console.ReadLine());

                if (Enum.TryParse<Survivor.EthnicityType>(userResponse, out raceType))
                {
                    isValid = true;
                    
                }
                else
                {
                    ClearInputBox();
                    DisplayInputErrorMessage("Please enter a valid ethnicity shown.");
                    
                }
                
            }
            return raceType;

        }

        /// <summary>
        /// display splash screen
        /// </summary>
        /// <returns>player chooses to play</returns>
        public bool DisplaySpashScreen()
        {
            bool playing = true;
            ConsoleKeyInfo keyPressed;

            Console.BackgroundColor = ConsoleTheme.SplashScreenBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.SplashScreenForegroundColor;
            Console.Clear();
            Console.CursorVisible = false;


            Console.SetCursorPosition(0, 10);
            string tabSpace = new String(' ', 35);

			Console.WriteLine(tabSpace + @"     ****                                                                  ");
			Console.WriteLine(tabSpace + @"   ********                                                                ");
			Console.WriteLine(tabSpace + @"  **  ******                                                               ");
			Console.WriteLine(tabSpace + @"   *   ******     ******                                                   ");
			Console.WriteLine(tabSpace + @"       ******   *********                                                  ");
			Console.WriteLine(tabSpace + @"        ****  *****   ***                                                  ");
			Console.WriteLine(tabSpace + @"        ***  ***     **     ▄▄·  ▄▄▄· .▄▄ · ▄▄▄▄▄ ▄▄▄· ▄▄▌ ▐ ▄▌ ▄▄▄·  ▄· ▄▌");
			Console.WriteLine(tabSpace + @"    ***********       *    ▐█ ▌*▐█ ▀█ ▐█ ▀. *██  ▐█ ▀█ ██· █▌▐█▐█ ▀█ ▐█*██▌");
			Console.WriteLine(tabSpace + @"  ******************       ██ ▄▄▄█▀▀█ ▄▀▀▀█▄ ▐█.*▄█▀▀█ ██*▐█▐▐▌▄█▀▀█ ▐█▌▐█*");
			Console.WriteLine(tabSpace + @" *****    ***** *******    ▐███▌▐█ *▐▌▐█▄*▐█ ▐█▌·▐█ *▐▌▐█▌██▐█▌▐█ *▐▌ ▐█▀·.");
			Console.WriteLine(tabSpace + @"***       ****   ********* ·▀▀▀  ▀  ▀  ▀▀▀▀  ▀▀▀  ▀  ▀  ▀▀▀▀ ▀* ▀  ▀   ▀ * ");
			Console.WriteLine(tabSpace + @"***       ****     *******                                                 ");
			Console.WriteLine(tabSpace + @" **       ****        *****                                                ");
			Console.WriteLine(tabSpace + @"   *      *****        ****                                                ");
			Console.WriteLine(tabSpace + @"          *****         ***                                                ");
			Console.WriteLine(tabSpace + @"         *******        **                                                 ");
			Console.WriteLine(tabSpace + @"        ********        *                                                  ");
			Console.WriteLine(tabSpace + @"       *********                                                           ");


			Console.SetCursorPosition(80, 25);
            Console.Write("Press any key to continue or Esc to exit.");
            keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.Escape)
            {
                playing = false;
            }

            return playing;
        }

        /// <summary>
        /// initialize the console window settings
        /// </summary>
        private static void InitializeDisplay()
        {
            //
            // control the console window properties
            //
            ConsoleWindowControl.DisableResize();
            ConsoleWindowControl.DisableMaximize();
            ConsoleWindowControl.DisableMinimize();
            Console.Title = "Castaway";

            //
            // set the default console window values
            //
            ConsoleWindowHelper.InitializeConsoleWindow();

            Console.CursorVisible = false;
        }

        /// <summary>
        /// display the correct menu in the menu box of the game screen
        /// </summary>
        /// <param name="menu">menu for current game state</param>
        private void DisplayMenuBox(Menu menu)
        {
            Console.BackgroundColor = ConsoleTheme.MenuBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MenuBorderColor;

            //
            // display menu box border
            //
            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.MenuBoxPositionTop,
                ConsoleLayout.MenuBoxPositionLeft,
                ConsoleLayout.MenuBoxWidth,
                ConsoleLayout.MenuBoxHeight);

            //
            // display menu box header
            //
            Console.BackgroundColor = ConsoleTheme.MenuBorderColor;
            Console.ForegroundColor = ConsoleTheme.MenuForegroundColor;
            Console.SetCursorPosition(ConsoleLayout.MenuBoxPositionLeft + 2, ConsoleLayout.MenuBoxPositionTop + 1);
            Console.Write(ConsoleWindowHelper.Center(menu.MenuTitle, ConsoleLayout.MenuBoxWidth - 4));

            //
            // display menu choices
            //
            Console.BackgroundColor = ConsoleTheme.MenuBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MenuForegroundColor;
            int topRow = ConsoleLayout.MenuBoxPositionTop + 3;

            foreach (KeyValuePair<char, SurvivorAction> menuChoice in menu.MenuChoices)
            {
                if (menuChoice.Value != SurvivorAction.None)
                {
                    string formatedMenuChoice = ConsoleWindowHelper.ToLabelFormat(menuChoice.Value.ToString());
                    Console.SetCursorPosition(ConsoleLayout.MenuBoxPositionLeft + 3, topRow++);
                    Console.Write($"{menuChoice.Key}. {formatedMenuChoice}");
                }
            }
        }

        /// <summary>
        /// display the text in the message box of the game screen
        /// </summary>
        /// <param name="headerText"></param>
        /// <param name="messageText"></param>
        private void DisplayMessageBox(string headerText, string messageText)
        {
            //
            // display the outline for the message box
            //
            Console.BackgroundColor = ConsoleTheme.MessageBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MessageBoxBorderColor;
            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.MessageBoxPositionTop,
                ConsoleLayout.MessageBoxPositionLeft,
                ConsoleLayout.MessageBoxWidth,
                ConsoleLayout.MessageBoxHeight);

            //
            // display message box header
            //
            Console.BackgroundColor = ConsoleTheme.MessageBoxBorderColor;
            Console.ForegroundColor = ConsoleTheme.MessageBoxForegroundColor;
            Console.SetCursorPosition(ConsoleLayout.MessageBoxPositionLeft + 2, ConsoleLayout.MessageBoxPositionTop + 1);
            Console.Write(ConsoleWindowHelper.Center(headerText, ConsoleLayout.MessageBoxWidth - 4));

            //
            // display the text for the message box
            //
            Console.BackgroundColor = ConsoleTheme.MessageBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MessageBoxForegroundColor;
            List<string> messageTextLines = new List<string>();
            messageTextLines = ConsoleWindowHelper.MessageBoxWordWrap(messageText, ConsoleLayout.MessageBoxWidth - 4);

            int startingRow = ConsoleLayout.MessageBoxPositionTop + 3;
            int endingRow = startingRow + messageTextLines.Count();
            int row = startingRow;
            foreach (string messageTextLine in messageTextLines)
            {
                Console.SetCursorPosition(ConsoleLayout.MessageBoxPositionLeft + 2, row);
                Console.Write(messageTextLine);
                row++;
            }

        }

        /// <summary>
        /// draw the status box on the game screen
        /// </summary>
        public void DisplayStatusBox()
        {
            Console.BackgroundColor = ConsoleTheme.StatusBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.StatusBoxBorderColor;

            //
            // display the outline for the status box
            //
            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.StatusBoxPositionTop,
                ConsoleLayout.StatusBoxPositionLeft,
                ConsoleLayout.StatusBoxWidth,
                ConsoleLayout.StatusBoxHeight);

            //
            // display the text for the status box if playing game
            //
            if (_viewStatus == ViewStatus.PlayingGame)
            {
                //
                // display status box header with title
                //
                Console.BackgroundColor = ConsoleTheme.StatusBoxBorderColor;
                Console.ForegroundColor = ConsoleTheme.StatusBoxForegroundColor;
                Console.SetCursorPosition(ConsoleLayout.StatusBoxPositionLeft + 2, ConsoleLayout.StatusBoxPositionTop + 1);
                Console.Write(ConsoleWindowHelper.Center("Game Stats", ConsoleLayout.StatusBoxWidth - 4));
                Console.BackgroundColor = ConsoleTheme.StatusBoxBackgroundColor;
                Console.ForegroundColor = ConsoleTheme.StatusBoxForegroundColor;

                //
                // display stats
                //
                int startingRow = ConsoleLayout.StatusBoxPositionTop + 3;
                int row = startingRow;
                foreach (string statusTextLine in Text.StatusBox(_gameSurvivor, _gameUniverse))
                {
                    Console.SetCursorPosition(ConsoleLayout.StatusBoxPositionLeft + 3, row);
                    Console.Write(statusTextLine);
                    row++;
                }
            }
            else
            {
                //
                // display status box header without header
                //
                Console.BackgroundColor = ConsoleTheme.StatusBoxBorderColor;
                Console.ForegroundColor = ConsoleTheme.StatusBoxForegroundColor;
                Console.SetCursorPosition(ConsoleLayout.StatusBoxPositionLeft + 2, ConsoleLayout.StatusBoxPositionTop + 1);
                Console.Write(ConsoleWindowHelper.Center("", ConsoleLayout.StatusBoxWidth - 4));
                Console.BackgroundColor = ConsoleTheme.StatusBoxBackgroundColor;
                Console.ForegroundColor = ConsoleTheme.StatusBoxForegroundColor;
            }
        }

        /// <summary>
        /// draw the input box on the game screen
        /// </summary>
        public void DisplayInputBox()
        {
            Console.BackgroundColor = ConsoleTheme.InputBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.InputBoxBorderColor;

            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.InputBoxPositionTop,
                ConsoleLayout.InputBoxPositionLeft,
                ConsoleLayout.InputBoxWidth,
                ConsoleLayout.InputBoxHeight);
        }

        /// <summary>
        /// display the prompt in the input box of the game screen
        /// </summary>
        /// <param name="prompt"></param>
        public void DisplayInputBoxPrompt(string prompt)
        {
            Console.SetCursorPosition(ConsoleLayout.InputBoxPositionLeft + 4, ConsoleLayout.InputBoxPositionTop + 1);
            Console.ForegroundColor = ConsoleTheme.InputBoxForegroundColor;
            Console.Write(prompt);
            Console.CursorVisible = true;
        }

        /// <summary>
        /// display the error message in the input box of the game screen
        /// </summary>
        /// <param name="errorMessage">error message text</param>
        public void DisplayInputErrorMessage(string errorMessage)
        {
            Console.SetCursorPosition(ConsoleLayout.InputBoxPositionLeft + 4, ConsoleLayout.InputBoxPositionTop + 2);
            Console.ForegroundColor = ConsoleTheme.InputBoxErrorMessageForegroundColor;
            Console.Write(errorMessage);
            Console.ForegroundColor = ConsoleTheme.InputBoxForegroundColor;
            Console.CursorVisible = true;
        }

        /// <summary>
        /// clear the input box
        /// </summary>
        private void ClearInputBox()
        {
            string backgroundColorString = new String(' ', ConsoleLayout.InputBoxWidth - 4);

            Console.ForegroundColor = ConsoleTheme.InputBoxBackgroundColor;
            for (int row = 1; row < ConsoleLayout.InputBoxHeight - 2; row++)
            {
                Console.SetCursorPosition(ConsoleLayout.InputBoxPositionLeft + 4, ConsoleLayout.InputBoxPositionTop + row);
                DisplayInputBoxPrompt(backgroundColorString);
            }
            Console.ForegroundColor = ConsoleTheme.InputBoxForegroundColor;
        }

        /// <summary>
        /// get the player's initial information at the beginning of the game
        /// </summary>
        /// <returns>traveler object with all properties updated</returns>
        public Survivor GetInitialSurvivorInfo()
        {
            Survivor survivor = new Survivor();

            //
            // intro
            //
            DisplayGamePlayScreen("Quest Initialization", Text.InitializeQuestIntro(), ActionMenu.QuestIntro, "");
            GetContinueKey();

            //
            // get survivor's name
            //
            DisplayGamePlayScreen("Quest Initialization - Name", Text.InitializeQuestGetSurvivorName(), ActionMenu.QuestIntro, "");
            DisplayInputBoxPrompt("Enter your name: ");
            survivor.Name = GetString();

            //
            // get suvivor's age
            //
            DisplayGamePlayScreen("Quest Initialization - Age", Text.InitializeQuestGetSurvivorAge(survivor), ActionMenu.QuestIntro, "");
            int gameSurvivorAge;

            GetInteger($"Enter your age, {survivor.Name}: ", 0, 1000000, out gameSurvivorAge);
            survivor.Age = gameSurvivorAge;

            //
            // get suvivor's race
            //
            DisplayGamePlayScreen("Quest Initialization - EthnicityType", Text.InitializeQuestGetSurvivorRace(survivor), ActionMenu.QuestIntro, "");
            DisplayInputBoxPrompt($"Enter your ethnicity, {survivor.Name}: ");
            survivor.Ethnicity = GetRace();

            //
            // echo the suvivor's info
            //
            DisplayGamePlayScreen("Quest Initialization - Complete", Text.InitializeQuestEchoSurvivorInfo(survivor), ActionMenu.QuestIntro, "");
            GetContinueKey();

            // 
            // change view status to playing game
            //
            _viewStatus = ViewStatus.PlayingGame;

            return survivor;
        }

        /// <summary>
        /// edit survivor info
        /// </summary>
        /// <returns>traveler object with all properties updated</returns>
        public Survivor EditSurvivorInfo(Survivor survivor)
        {

            //
            // intro
            //
            DisplayGamePlayScreen("Edit Survivor Info", Text.EditSurvivorInfo(survivor), ActionMenu.EditPlayerInfo, "");
            DisplayInputBoxPrompt("Enter what info you would like to change: ");

            // get survivor choice and validate
            bool isValid = false;
            while (!isValid)
            {
                string userChoice = Console.ReadLine().ToLower();
                switch (userChoice)
                {
                    case "name":
                        //
                        // get survivor's new name
                        //
                        DisplayGamePlayScreen("Edit Survivor Info - Name", Text.EditSurvivorInfoGetSurvivorName(), ActionMenu.EditPlayerInfo, "");
                        DisplayInputBoxPrompt("Enter your name: ");
                        survivor.Name = GetString();
                        isValid = true;
                        break;
                    case "age":
                        //
                        // get survivor's new age
                        //
                        DisplayGamePlayScreen("Edit Survivor Info - Age", Text.EditSurvivorInfoGetSurvivorAge(survivor), ActionMenu.EditPlayerInfo, "");
                        int gameSurvivorAge;

                        GetInteger($"Enter your age, {survivor.Name}: ", 0, 1000000, out gameSurvivorAge);
                        survivor.Age = gameSurvivorAge;
                        isValid = true;
                        break;
                    case "ethnicity":
                        //
                        // get survivor's new race
                        //
                        DisplayGamePlayScreen("Edit Survivor Info - EthnicityType", Text.EditSurvivorInfoGetSurvivorRace(survivor), ActionMenu.EditPlayerInfo, "");
                        DisplayInputBoxPrompt($"Enter your ethnicity, {survivor.Name}: ");
                        survivor.Ethnicity = GetRace();
                        isValid = true;
                        break;
                    default:
                        DisplayInputErrorMessage("You did not enter a valid option.");
                        break;
                }
            }

            //
            // echo the traveler's info
            //
            DisplayGamePlayScreen("Edit Survivor Info - Complete", Text.EditSurvivorInfoEchoSurvivorInfo(survivor), ActionMenu.AdminMenu, "");

            return survivor;
        }

        public void DisplayListOfIslandLocations()
        {
            DisplayGamePlayScreen("List: Island Locations", Text.ListSpaceTimeLocations(_gameUniverse.IslandLocations), ActionMenu.AdminMenu, "");
        }

		public void DisplayListOfAllGameObjects()
		{
			DisplayGamePlayScreen("List: Game Objects", Text.ListAllGameObjects(_gameUniverse.GameObjects), ActionMenu.AdminMenu, "");
		}

		public int DisplayGetGameObjectToLookAt()
		{
			int gameObjectId = 0;
			bool validGameObjectId = false;

			//
			// get a list of game onjects in the current space-time location
			//
			List<GameObject> gameObjectsInIslandLocation = _gameUniverse.GetGameObjectsByIslandLocationId(_gameSurvivor.IslandLocationID);

			if (gameObjectsInIslandLocation.Count > 0)
			{
				DisplayGamePlayScreen("Look at a Object", Text.GameObjectsChooseList(gameObjectsInIslandLocation), ActionMenu.ObjectMenu, "");

				while (!validGameObjectId)
				{
					//
					// get an integer from the player
					//
					GetInteger($"Enter the Id number of the object you wish to look at: ", 0, 0, out gameObjectId);

					//
					// validate integer as a valid game object id and in current location
					//
					if (_gameUniverse.IsValidGameObjectByLocationId(gameObjectId, _gameSurvivor.IslandLocationID))
					{
						validGameObjectId = true;
					}
					else
					{
						ClearInputBox();
						DisplayInputErrorMessage("It appears you entered an invalid game object id. Please try again.");
					}
				}
			}
			else
			{
				ClearInputBox();
				DisplayGamePlayScreen("Look at a Object", "It appears there are no game objects here.", ActionMenu.ObjectMenu, "");
			}

			return gameObjectId;
		}

		public void DisplayGameObjectInfo(GameObject gameObject)
		{
			DisplayGamePlayScreen("Current Location", Text.LookAt(gameObject), ActionMenu.ObjectMenu, "");
		}

        public int DisplayGetSurvivorObjectToPickUp()
        {
            int gameObjectId = 0;
            bool validGameObjectId = false;

            //
            // get a list of survivor objects in the current island location
            //
            List<SurvivorObject> survivorObjectsInIslandLocation = _gameUniverse.GetSurvivorObjectsByIslandLocationId(_gameSurvivor.IslandLocationID);

            if (survivorObjectsInIslandLocation.Count > 0)
            {
                DisplayGamePlayScreen("Pick Up Game Object", Text.GameObjectsChooseList(survivorObjectsInIslandLocation), ActionMenu.ObjectMenu, "");

                while (!validGameObjectId)
                {
                    //
                    // get an integer from the player
                    //
                    GetInteger($"Enter the Id number of the object you wish to add to your inventory: ", 0, 0, out gameObjectId);

                    //
                    // validate integer as a valid game object id and in current location
                    //
                    if (_gameUniverse.IsValidSurvivorObjectByLocationId(gameObjectId, _gameSurvivor.IslandLocationID))
                    {
                        SurvivorObject survivorObject = _gameUniverse.GetGameObjectById(gameObjectId) as SurvivorObject;
                        if (survivorObject.CanInventory)
                        {
                            validGameObjectId = true;
                        }
                        else
                        {
                            ClearInputBox();
                            DisplayInputErrorMessage("It appears you may not inventory that object. Please try again.");
                        }
                    }
                    else
                    {
                        ClearInputBox();
                        DisplayInputErrorMessage("It appears that you entered an invalid game object id. Please try again.");
                    }
                }
            }
            else
            {
                DisplayGamePlayScreen("Pick Up Game Object", "It appears there are no game objects here.", ActionMenu.ObjectMenu, "");
            }

            return gameObjectId;
        }

        public void DisplayConfirmSurvivorObjectAddedToInventory(SurvivorObject objectAddedToInventory)
        {
            DisplayGamePlayScreen("Pick Up Game Object", $"The {objectAddedToInventory.Name} has been added to your inventory.", ActionMenu.ObjectMenu, "");
        }

        public int DisplayGetInventoryObjectToPutDown()
        {
            int survivorObjectId = 0;
            bool validInventoryObjectId = false;

            if (_gameSurvivor.Inventory.Count > 0)
            {
                DisplayGamePlayScreen("Put Down Game Object", Text.GameObjectsChooseList(_gameSurvivor.Inventory), ActionMenu.ObjectMenu, "");

                while (!validInventoryObjectId)
                {
                    //
                    // get an integer from the player
                    //
                    GetInteger($"Enter the Id number of the object you wish to remove from your inventory: ", 0, 0, out survivorObjectId);

                    //
                    // find object in inventory
                    // note: LINQ used, but a foreach loop may also be used
                    //
                    SurvivorObject objectToPutDown = _gameSurvivor.Inventory.FirstOrDefault(o => o.Id == survivorObjectId);

                    //
                    // validate object in inventory
                    //
                    if (objectToPutDown != null)
                    {
                        validInventoryObjectId = true;
                    }
                    else
                    {
                        ClearInputBox();
                        DisplayInputErrorMessage("It appears you entered the Id of an object not in the inventory. Please try again.");
                    }
                }
            }
            else
            {
                DisplayGamePlayScreen("Pick Up Game Object", "It appears there are no objects currently in inventory.", ActionMenu.ObjectMenu, "");
            }

            return survivorObjectId;
        }

        public void DisplayConfirmSurvivorObjectRemovedFromInventory(SurvivorObject objectRemovedFromInventory)
        {
            DisplayGamePlayScreen("Put Down Game Object", $"The {objectRemovedFromInventory.Name} has been removed from your inventory.", ActionMenu.ObjectMenu, "");
        }

        public void DisplayListOfAllNpcObjects()
        {
            DisplayGamePlayScreen("List: Npc Objects", Text.ListAllNpcObjects(_gameUniverse.Npcs), ActionMenu.AdminMenu, "");
        }

        #region ----- display responses to menu action choices -----

        public void DisplaySurvivorInfo()
        {
            DisplayGamePlayScreen("Survivor Information", Text.SurvivorInfo(_gameSurvivor), ActionMenu.SurvivorMenu, "");
        }
        public void DisplayLookAround()
        {
			//
			// get current island location
            //
			IslandLocation currentIslandLocation = _gameUniverse.GetIslandLocationById(_gameSurvivor.IslandLocationID);

            //
            // get list of game objects in current space-time location
            //
            List<GameObject> gameObjectsInCurrentIslandLocation = _gameUniverse.GetGameObjectsByIslandLocationId(_gameSurvivor.IslandLocationID);

            //
            // get list of NPCs in current space-time location
            //
            List<Npc> npcsInCurrentIslandLocation = _gameUniverse.GetNpcsBySpaceTimeLocationId(_gameSurvivor.IslandLocationID);

            string messageBoxText = Text.LookAround(currentIslandLocation) + Environment.NewLine + Environment.NewLine;
			messageBoxText += Text.GameObjectsChooseList(gameObjectsInCurrentIslandLocation);
            messageBoxText += Text.NpcsChooseList(npcsInCurrentIslandLocation);

            DisplayGamePlayScreen("Current Location", messageBoxText, ActionMenu.MainMenu, "");
		}

        public int DisplayGetNextIslandLocation()
        {
            int islandLocationId = 0;
            bool validIslandLocationId = false;

            //UpdateRoomAccessability(islandLocationId);

            DisplayGamePlayScreen("Travel to a New Island Location", Text.Travel(_gameSurvivor, _gameUniverse.IslandLocations), ActionMenu.MainMenu, "");

            while (!validIslandLocationId)
            {
                //
                // get an integer from the player
                //
                GetInteger($"Enter your new location {_gameSurvivor.Name}: ", 1, _gameUniverse.GetMaxIslandLocationId(), out islandLocationId);

                //
                // validate integer as a valid space-time location id and determine accessibility
                //
                if (_gameUniverse.IsValidIslandLocationId(islandLocationId))
                {
                    if (_gameUniverse.GetIslandLocationById(islandLocationId).Accessible)
                    {
                        validIslandLocationId = true;
                    }
                    else
                    {
                        ClearInputBox();
                        DisplayInputErrorMessage("It appears you are attempting to travel to an inaccessible location. Please try again.");
                    }
                }
                else
                {
                    DisplayInputErrorMessage("It appears you entered an invalid Island location ID. Please try again.");
                }
            }

            //CheckForBunny(islandLocationId);
            CheckHealthPoints();

            return islandLocationId;
        }

        //public void CheckForBunny(int stl)
        //{
        //    //
        //    // if there is a stuffed bunny at the location, they will lose 50 health points
        //    //
        //    if (_gameUniverse.SpaceTimeLocations[stl - 1].GeneralContents == "stuffed bunny")
        //    {
        //        _gameTraveler.Health = _gameTraveler.Health - 50;
        //    }
        //}

        public void CheckHealthPoints()
        {
            //
            // if health is at or below zero, they lose a life and health is back at 100
            //
            if (_gameSurvivor.Health <= 0)
            {
                _gameSurvivor.Lives = _gameSurvivor.Lives - 1;
                _gameSurvivor.Health = 100;
            }
        }

        public void DisplayLocationsVisited()
        {
            //
            // generate a list of island locations that have been visited
            //
            List<IslandLocation> visitedIslandLocations = new List<IslandLocation>();
            foreach (int islandLocationId in _gameSurvivor.IslandLocationsVisisted)
            {
                visitedIslandLocations.Add(_gameUniverse.GetIslandLocationById(islandLocationId));
            }

            DisplayGamePlayScreen("Island Locations Visited", Text.VisitedLocations(visitedIslandLocations), ActionMenu.SurvivorMenu, "");
        }

		public void DisplayInventory()
		{
			DisplayGamePlayScreen("Current Inventory", Text.CurrentInventory(_gameSurvivor.Inventory), ActionMenu.SurvivorMenu, "");
		}

        public int DisplayGetNpcToTalkTo()
        {
            int npcId = 0;
            bool validNpcId = false;

            //
            // get a list of NPCs in the current space-time location
            //
            List<Npc> npcsInSpaceTimeLocation = _gameUniverse.GetNpcsBySpaceTimeLocationId(_gameSurvivor.IslandLocationID);

            if (npcsInSpaceTimeLocation.Count > 0)
            {
                DisplayGamePlayScreen("Chose Character to Speak With", Text.NpcsChooseList(npcsInSpaceTimeLocation), ActionMenu.NpcMenu, "");

                while (!validNpcId)
                {
                    //
                    // get an integer from the player
                    //
                    GetInteger($"Enter the Id number of the character you wish to speak with: ", 0, 0, out npcId);

                    //
                    // validate integer as a valid NPC id and in current location
                    //
                    if (_gameUniverse.IsValidNpcByLocationId(npcId, _gameSurvivor.IslandLocationID))
                    {
                        Npc npc = _gameUniverse.GetNpcById(npcId);
                        if (npc is ISpeak)
                        {
                            validNpcId = true;
                        }
                        else
                        {
                            ClearInputBox();
                            DisplayInputErrorMessage("It appears this character has nothing to say. Please try again.");
                        }
                    }
                    else
                    {
                        ClearInputBox();
                        DisplayInputErrorMessage("It appears you entered and invalid NPC id. Please try again.");
                    }
                }
            }
            else
            {
                DisplayGamePlayScreen("Choose Character to Speak With", "It appears there are no NPCs here.", ActionMenu.NpcMenu, "");
            }

            return npcId;
        }

        public void DisplayTalkTo(Npc npc)
        {
            ISpeak speakingNpc = npc as ISpeak;

            string message = speakingNpc.Speak();

            if (message == "")
            {
                message = "It appears this character has nothing to say. Please try again.";
            }

            DisplayGamePlayScreen("Speak to Character", message, ActionMenu.NpcMenu, "");
        }

        public int DisplayGetObjectToInteractWithId()
        {
            int interactiveObjectId = 0;
            bool validInteractiveObject = false;

			//
			// get a list of game onjects in the current space-time location
			//
			List<InteractiveObject> interactiveObjectsInIslandLocation = _gameUniverse.GetInteractiveObjectsByIslandLocationId(_gameSurvivor.IslandLocationID) ;

			if (interactiveObjectsInIslandLocation.Count > 0)
			{
				DisplayGamePlayScreen("Interact With an Object", Text.InteractiveObjectsChooseList(interactiveObjectsInIslandLocation), ActionMenu.ObjectMenu, "");

				while (!validInteractiveObject)
				{
					//
					// get an integer from the player
					//
					GetInteger($"Enter the Id number of the object you wish to interact with: ", 0, 0, out interactiveObjectId);

					//
					// validate integer as a valid game object id and in current location
					//
					if (_gameUniverse.IsValidGameObjectByLocationId(interactiveObjectId, _gameSurvivor.IslandLocationID))
					{
						validInteractiveObject = true;
					}
					else
					{
						ClearInputBox();
						DisplayInputErrorMessage("It appears you entered an invalid game object id. Please try again.");
					}
				}
			}
			else
			{
				ClearInputBox();
				DisplayGamePlayScreen("Interact With an Object", "It appears there are no game objects here.", ActionMenu.ObjectMenu, "");
                interactiveObjectId = 0;
			}
            
            return interactiveObjectId;
        }

        public string GetWaterBodyInteraction()
        {
            string interaction = "";
            bool validInteraction = false;
            
            DisplayGamePlayScreen("Interact With an Object", Text.WaterBodyInteraction(), ActionMenu.ObjectMenu, "");
            DisplayInputBoxPrompt("Please enter an interaction: ");

            while (!validInteraction)
            {
                //
                // get string from the player
                //

                interaction = GetString().ToLower();

                //
                // validate string as a valid choice
                //
                switch (interaction)
                {
                    case "fish":
                    case "bathe":
                    //case "dive":
                        validInteraction = true;
                        break;
                    default:
                        ClearInputBox();
                        DisplayInputErrorMessage("It appears you entered an invalid game object id. Please try again.");
                        break;
                }
            }

            return interaction;
        }

        public void DisplayFishingErrorMessage()
        {
            DisplayGamePlayScreen("Interact With an Object", "It appears that there are no fish here.", ActionMenu.ObjectMenu, "");
        }

        public void DisplayBathingMessage(int healthPoints)
        {
            if (healthPoints > 0)
            {
                DisplayGamePlayScreen("Interact With an Object", $"You have recieved {healthPoints} health points from bathing.", ActionMenu.ObjectMenu, "");
            }
            else
            {
                DisplayGamePlayScreen("Interact With an Object", $"You are so healthy, you can't gain anymore health points from bathing.", ActionMenu.ObjectMenu, "");
            }
        }

        public void DisplayGameWon()
        {
            DisplayGamePlayScreen("Game Won!", $"You won the game by assembling the radio! Congratulations ! \nPress any key to exit.", ActionMenu.ObjectMenu, "");
            Console.ReadKey();
        }

        #endregion

        #endregion
    }
}
