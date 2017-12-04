using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// class to store static and to generate dynamic text for the message and input boxes
    /// </summary>
    public static class Text
    {
        public static List<string> HeaderText = new List<string>() { "Castaway" };
        public static List<string> FooterText = new List<string>() { "Awkward Flamingo Studios, 2016" };

        #region INTITIAL GAME SETUP

        public static string QuestIntro()
        {
            string messageBoxText =
            "On an uncharted island chain in the Pacific, you have " +
            "washed up after your recreational boat was lost at sea " +
            "during a storm. You have nothing with you but the clothes " +
            "on your back. You will have to learn how to survive in " +
            "the wild by: hunting and gathering food; crafting shelter, " +
            "tools, and clothing; and avoiding attacks with wild animals. " +
            "You will be able to travel to and explore locations on the " +
            "island chain and discover your lost crew.\n" +
            " \n" +
            "Press the Esc key to exit the game at any point.\n" +
            " \n" +
            "Your quest for survival begins now.\n" +
            " \n" +
            "\tYour first task will be to set up your character information.\n" +
            " \n" +
            "\tPress any key to begin.\n";

            return messageBoxText;
        }

        //public static string CurrrentLocationInfo()
        //{
        //    string messageBoxText =
        //    "You are now on First Beach, upon Shipwreck Island, located somewhere in the Pacific Ocean. " +
        //    "You were on a boat with some friends from college, on summer vaction, enjoying the sun. " +
        //    "Now you are here. You can barely remember what happened, but you do know that " +
        //    "your boat was lost at sea and you woke up on the shore of this beach. "+ 
        //    "It is warm here, just sand, shore, and some palm trees.\n" +
        //    " \n" +
        //    "\tChoose from the menu options to proceed.\n";

        //    return messageBoxText;
        //}

        #region Initialize Quest Text

        public static string InitializeQuestIntro()
        {
            string messageBoxText =
                "Before you begin your quest for survival, we much gather some of your information.\n" +
                " \n" +
                "You will be prompted for the required information.\n" +
                " \n" +
                "\tPress any key to begin.";

            return messageBoxText;
        }

        public static string InitializeQuestGetSurvivorName()
        {
            string messageBoxText =
                "Enter your name, survior.\n" +
                " \n" +
                "Please use the name you wish to be referred during your quest.";

            return messageBoxText;
        }

        public static string InitializeQuestGetSurvivorAge(Survivor gameSurvivor)
        {
            string messageBoxText =
                $"Very good then, we will call you {gameSurvivor.Name}.\n" +
                " \n" +
                "Enter your age below.\n";

            return messageBoxText;
        }

        public static string InitializeQuestGetSurvivorRace(Survivor gameSurvivor)
        {
            string messageBoxText =
                $"{gameSurvivor.Name}, it will be important for us to know your ethnicity.\n" +
                " \n" +
                "Enter your ethnicity below.\n" +
                " \n" +
                "Please use one of the following." +
                " \n";

            string raceList = null;

            foreach (Survivor.EthnicityType race in Enum.GetValues(typeof(Survivor.EthnicityType)))
            {
                if (race != Survivor.EthnicityType.None)
                {
                    raceList += $"\t{race}\n";
                }
            }

            messageBoxText += raceList;

            return messageBoxText;
        }

        public static string InitializeQuestEchoSurvivorInfo(Survivor gameSurvivor)
        {
            string messageBoxText =
                $"Very good then {gameSurvivor.Name}.\n" +
                " \n" +
                "It appears we have all the necessary data to begin your quest. You will find it" +
                " listed below.\n" +
                " \n" +
                $"\tSurvivor Name: {gameSurvivor.Name}\n" +
                $"\tSurvivor Age: {gameSurvivor.Age}\n" +
                $"\tSurvivor EthnicityType: {gameSurvivor.Ethnicity}\n" +
                " \n" +
                "Press any key to begin.";

            return messageBoxText;
        }
        #region EDIT SURVIVOR INFO 

        public static string EditSurvivorInfoGetSurvivorName()
        {
            string messageBoxText =
                "Enter your new name, survior.\n" +
                " \n" +
                "Please use the name you wish to be referred during your quest.";

            return messageBoxText;
        }

        public static string EditSurvivorInfoGetSurvivorAge(Survivor gameSurvivor)
        {
            string messageBoxText =
                
                "Enter your new age below.\n";

            return messageBoxText;
        }

        public static string EditSurvivorInfoGetSurvivorRace(Survivor gameSurvivor)
        {
            string messageBoxText =
                $"{gameSurvivor.Name}, please enter your new ethnicity below.\n" +
                " \n" +
                "Please use one of the following." +
                " \n";

            string raceList = null;

            foreach (Survivor.EthnicityType race in Enum.GetValues(typeof(Survivor.EthnicityType)))
            {
                if (race != Survivor.EthnicityType.None)
                {
                    raceList += $"\t{race}\n";
                }
            }

            messageBoxText += raceList;

            return messageBoxText;
        }

        public static string EditSurvivorInfoEchoSurvivorInfo(Survivor gameSurvivor)
        {
            string messageBoxText =
                $"Very good then {gameSurvivor.Name}.\n" +
                " \n" +
                "You will find the changes you have made to your information listed below.\n" +
                " \n" +
                $"\tSurvivor Name: {gameSurvivor.Name}\n" +
                $"\tSurvivor Age: {gameSurvivor.Age}\n" +
                $"\tSurvivor EthnicityType: {gameSurvivor.Ethnicity}\n" +
                " \n" +
                "Please select a menu option.";

            return messageBoxText;
        }
        #endregion

        #endregion

        #endregion

        #region MAIN MENU ACTION SCREENS

        public static string SurvivorInfo(Survivor gameSurvivor)
        {
            string messageBoxText =
                $"\tSurvivor Name: {gameSurvivor.Name}\n" +
                $"\tSurvivor Age: {gameSurvivor.Age}\n" +
                $"\tSurvivor EthnicityType: {gameSurvivor.Ethnicity}\n" +
                " \n";

            return messageBoxText;
        }

        public static string EditSurvivorInfo(Survivor gameSurvivor)
        {
            string messageBoxText =
                $"\tSurvivor Name: {gameSurvivor.Name}\n" +
                $"\tSurvivor Age: {gameSurvivor.Age}\n" +
                $"\tSurvivor EthnicityType: {gameSurvivor.Ethnicity}\n" +
                " \n" +
                "\tOptions:\n" +
                "\n" +
                "\tName\n" +
                "\tAge\n" +
                "\tEthnicity\n" +
                "\n" +
                "\tPlease enter what you would like to edit below.";
                

            return messageBoxText;
        }


        //public static string Travel(int currentSpaceTimeLocationId, List<SpaceTimeLocation> spaceTimeLocations)
        //{
        //    string messageBoxText =
        //        $"{gameSurvivor.Name}, Aion Base will need to know the name of the new location.\n" +
        //        " \n" +
        //        "Enter the ID number of your desired location from the table below.\n" +
        //        " \n";


        //    string spaceTimeLocationList = null;

        //    foreach (SpaceTimeLocation spaceTimeLocation in spaceTimeLocations)
        //    {
        //        if (race != Character.EthnicityType.None)
        //        {
        //            raceList += $"\t{race}\n";
        //        }
        //    }

        //    messageBoxText += raceList;

        //    return messageBoxText;
        //}

        #endregion

        public static List<string> StatusBox(Survivor survivor, Universe universe)
        {
            List<string> statusBoxText = new List<string>();

            statusBoxText.Add($"Experience Points: {survivor.ExperiencePoints}\n");
            statusBoxText.Add($"Health: {survivor.Health}\n");
            statusBoxText.Add($"Lives: {survivor.Lives}\n");

            return statusBoxText;
        }

        public static string ListSpaceTimeLocations(IEnumerable<IslandLocation> islandLocations)
        {
            string messageBoxText =
                "Island Locations\n" +
                "\n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "\n" +
                "---" + "------------------------------" + "\n";

            //
            // display all locations
            //
            string islandLocationList = null;
            foreach (IslandLocation islandLocation in islandLocations)
            {
                islandLocationList +=
                    $"{islandLocation.IslandLocationID}".PadRight(10) +
                    $"{islandLocation.CommonName}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += islandLocationList;

            return messageBoxText;
        }

        public static string LookAround(IslandLocation islandLocation)
        {
            string messageBoxText =
                $"Current Location: {islandLocation.CommonName}\n" +
                "\n" +
                islandLocation.GeneralContents;

            return messageBoxText;
        }

        public static string Travel(Survivor gameSurvivor, List<IslandLocation> islandLocations)
        {
            string messageBoxText =
                $"{gameSurvivor.Name}, we will need to know the name of the new location.\n" +
                "\n" +
                "Enter the ID number of your desired location from the table below.\n" +
                "\n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) /*+ "Accessible".PadRight(10)*/ + "\n" +
                "---".PadRight(10) + "---------------------".PadRight(30) /*+ "-------".PadRight(10)*/ + "\n";

            ////
            //// display all locations except the current location
            ////
            //string islandLocationList = null;
            //foreach (IslandLocation islandLocation in islandLocations)
            //{
            //    if (islandLocation.IslandLocationID != gameSurvivor.IslandLocationID)
            //    {
            //        islandLocationList +=
            //            $"{islandLocation.IslandLocationID}".PadRight(10) +
            //            $"{islandLocation.CommonName}".PadRight(30) +
            //            $"{islandLocation.Accessible}".PadRight(10) +
            //            Environment.NewLine;
            //    }
            //}

            //
            // display all locations except the current location
            //
            string islandLocationList = null;
            foreach (IslandLocation islandLocation in islandLocations)
            {
                if (islandLocation.IslandLocationID != gameSurvivor.IslandLocationID && islandLocation.Accessible == true)
                {
                    islandLocationList +=
                        $"{islandLocation.IslandLocationID}".PadRight(10) +
                        $"{islandLocation.CommonName}".PadRight(30) +
                        //$"{islandLocation.Accessible}".PadRight(10) +
                        Environment.NewLine;
                }
            }

            messageBoxText += islandLocationList;

            return messageBoxText;
        }

        public static string CurrentLocationInfo(IslandLocation islandLocation)
        {
            string messageBoxText =
                $"Current Location: {islandLocation.CommonName}\n" +
                "\n" +
                islandLocation.Description;

            return messageBoxText;
        }

        public static string VisitedLocations(IEnumerable<IslandLocation> islandLocations)
        {
            string messageTextBox =
                "Island Locations Visited\n" +
                "\n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "\n" +
                "---".PadRight(10) + "------------------------".PadRight(30) + "\n";

            // 
            // display all locations
            //
            string islandLocationList = null;
            foreach (IslandLocation islandLocation in islandLocations)
            {
                islandLocationList +=
                    $"{islandLocation.IslandLocationID}".PadRight(10) +
                    $"{islandLocation.CommonName}".PadRight(30) +
                    "\n";
            }

            messageTextBox += islandLocationList;

            return messageTextBox;
        }

		public static string ListAllGameObjects(IEnumerable<GameObject> gameObjects)
		{
			//
			// display table name and column headers
			//
			string messageBoxText =
				"GameObjects\n" +
				"\n" +

				//
				// display table header
				//
				"ID".PadRight(10) +
				"Name".PadRight(30) +
				"Space-Time Location Id".PadRight(10) + "\n" +
				"---".PadRight(10) +
				"----------------------".PadRight(30) +
				"----------------------".PadRight(10) + "\n";

			//
			// display all traveler objects in rows
			//
			string gameObjectRows = null;
			foreach (GameObject gameObject in gameObjects)
			{
				gameObjectRows +=
					$"{gameObject.Id}".PadRight(10) +
					$"{gameObject.Name}".PadRight(30) +
					$"{gameObject.IslandLocationId}".PadRight(10) +
					Environment.NewLine;
			}

			messageBoxText += gameObjectRows;

			return messageBoxText;
		}

		public static string GameObjectsChooseList(IEnumerable<GameObject> gameObjects)
		{
			//
			// display table name and column headers
			//
			string messageBoxText =
				"Game Objects\n" +
				"\n" +

				//
				// display table header
				//
				"ID".PadRight(10) +
				"Name".PadRight(30) + "\n" +
				"---".PadRight(10) +
				"----------------------".PadRight(30) + "\n";

			// 
			// display all traveler objects in rows
			//
			string gameObjectRows = null;
			foreach (GameObject gameObject in gameObjects)
			{
                // check if item is a survivor object
                // check if survivor object is visible
                // if it is visible, display it
                if (gameObject is SurvivorObject)
                {
                    SurvivorObject survivorObject = gameObject as SurvivorObject;

                    if (survivorObject.IsVisible == true)
                    {
                        gameObjectRows +=
                        $"{survivorObject.Id}".PadRight(10) +
                        $"{survivorObject.Name}".PadRight(30) +
                        Environment.NewLine;
                    }
                }
                else
                {
                    gameObjectRows +=
                    $"{gameObject.Id}".PadRight(10) +
                    $"{gameObject.Name}".PadRight(30) +
                    Environment.NewLine;
                }
            }

			messageBoxText += gameObjectRows;

			return messageBoxText;
		}

        public static string InteractiveObjectsChooseList(IEnumerable<GameObject> gameObjects)
        {
            //
            // display table name and column headers
            //
            string messageBoxText =
                "Interactive Objects\n" +
                "\n" +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) + "\n" +
                "---".PadRight(10) +
                "----------------------".PadRight(30) + "\n";

            // 
            // display all traveler objects in rows
            //
            string gameObjectRows = null;
            foreach (GameObject gameObject in gameObjects)
            {
                if (gameObject is InteractiveObject)
                {
                    InteractiveObject interactiveObject = gameObject as InteractiveObject;

                    // Only display waterbodies, other objects do not have functionality yet
                    if (interactiveObject.Type == InteractiveObjectType.WaterBody)
                    {
                        gameObjectRows +=
                        $"{interactiveObject.Id}".PadRight(10) +
                        $"{interactiveObject.Name}".PadRight(30) +
                        Environment.NewLine;
                    }
                }
            }

            messageBoxText += gameObjectRows;

            return messageBoxText;
        }

        public static string LookAt(GameObject gameObject)
		{
			string messageBoxText = "";

			messageBoxText =
				$"{gameObject.Name}\n" +
				"\n" +
				$"{gameObject.Description}\n" +
				"\n";

			if (gameObject is SurvivorObject)
			{
				SurvivorObject survivorObject = gameObject as SurvivorObject;

				messageBoxText += $"The {survivorObject.Name} has a value of {survivorObject.Value} and ";

				if (survivorObject.CanInventory)
				{
					messageBoxText += "may be added to your inventory.";
				}
				else
				{
					messageBoxText += "may not be added to your inventory.";
				}
			}
			else
			{
				messageBoxText += $"The {gameObject.Name} may not be added to your inventory.";
			}

			return messageBoxText;
		}

		public static string CurrentInventory(IEnumerable<SurvivorObject> inventory)
		{
			string messageBoxText = "";

			//
			// display table header
			//
			messageBoxText =
				"ID".PadRight(10) +
				"Name".PadRight(30) +
				"Type".PadRight(10) +
				"\n" +
				"---".PadRight(10) +
				"-----------------------------".PadRight(30) +
				"----------------------".PadRight(10) +
				"\n";

			//
			// display all traveler objects in rows
			//
			string inventoryObjectRows = null;
			foreach (SurvivorObject inventoryObject in inventory)
			{
				inventoryObjectRows +=
					$"{inventoryObject.Id}".PadRight(10) +
					$"{inventoryObject.Name}".PadRight(30) +
					$"{inventoryObject.Type}".PadRight(10) +
					Environment.NewLine;
			}

			messageBoxText += inventoryObjectRows;

			return messageBoxText;
		}

        public static string ListAllNpcObjects(IEnumerable<Npc> npcObjects)
        {
            //
            // display table name and column headers
            //
            string messageBoxText =
                "NPC Objects\n" +
                "\n" +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) +
                "Space-Time Location Id".PadRight(10) + "\n" +
                "---".PadRight(10) +
                "-----------------------".PadRight(30) +
                "-----------------------".PadRight(10) + "\n";

            //
            // display all npc objects in rows
            //
            string npcObjectRows = null;
            foreach (Npc npcObject in npcObjects)
            {
                npcObjectRows +=
                    $"{npcObject.Id}".PadRight(10) +
                    $"{npcObject.Name}".PadRight(30) +
                    $"{npcObject.IslandLocationID}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += npcObjectRows;

            return messageBoxText;
        }

        public static string NpcsChooseList(IEnumerable<Npc> npcs)
        {
            //
            // display table name and column headers
            //
            string messageBoxText =
                Environment.NewLine +
                "NPCs\n" +
                Environment.NewLine +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) + "\n" +
                "---".PadRight(10) +
                "-----------------------".PadRight(30) + "\n";

            //
            // display all npcs in rows
            //
            string npcRows = null;
            foreach (Npc npc in npcs)
            {
                npcRows +=
                    $"{npc.Id}".PadRight(10) +
                    $"{npc.Name}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += npcRows;

            return messageBoxText;
        }

        public static string WaterBodyInteraction()
        {
            string messageBoxText =
                Environment.NewLine +
                "Water Body Interaction\n" +
                Environment.NewLine +

                //
                // display choices
                //
                "Fish\n" +
                "Bathe\n" +
                //"Dive\n" +
                Environment.NewLine +
                "Please enter the interaction you would like to perform:\n";

            return messageBoxText;
        }
    }
}
