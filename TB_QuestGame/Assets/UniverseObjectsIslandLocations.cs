using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TB_QuestGame;

namespace TB_QuestGame
{
    /// <summary>
    /// static class to hold all objects in the game universe; locations, game objects, npc's
    /// </summary>
    public static partial class UniverseObjects
    {
        public static List<IslandLocation> IslandLocations = new List<IslandLocation>()
        {
            #region Shipwreck Island
            new IslandLocation
            {
                CommonName = "First Beach",
                IslandLocationID = 1,
                Description = "This is the beach you washed up on, located on Shipwreck Island.\n" +
                    "The beach is wide and sandy, " +
                    "populated with palm trees and driftwood. " +
                    "Ahead of you is the shore and the sea, " +
                    "behind you is a thick jungle. \n",
                GeneralContents = "Coconuts, Clams, Fish, " +
                    "Driftwood, Bamboo, Nautilus Shell, Large Clam Shell, Palm Fronds, " +
                    "Emergency Fire Pit, Workbench, Shore \n",
                Accessible = true,
                ExperiencePoints = 10
            },

            new IslandLocation
            {
                CommonName = "Deep Jungle",
                IslandLocationID = 2,
                Description = "The Deep Jungle has a dark, damp atmosphere, with vines hanging all around you. " +
                    "Located northwest of First Beach on Shipwreck Island, the jungle " +
                    "provides an excellent abundance of food and supplies.",
                GeneralContents = "Bananas, Long Beans, Guarana, Rumberries, Starfruit, Cucumbers, Snowberries, Almonds, " +
                    "Vines, Rattan, Banana Leaves, Bamboo, Mandrake Root, Privet, Manchineel, Hardwood, " +
                    "Monkeys",
                Accessible = true,
                ExperiencePoints = -5
            },

            new IslandLocation
            {
                CommonName = "Pier Beach",
                IslandLocationID = 3,
                Description = "Pier Beach is another beach located on Shipwreck Island, northwest of the Deep Jungle and west of Shipwreck Lagoon. " +
                              "Here you can see a damaged, ancient pier; and a speck in the distance, which you suspect to be another island. " +
                              "You begin to get ideas of builing a boat to discover the new location.",
                GeneralContents = "Coconuts, Bananas, Ginger, Blackberries, Almonds, Fish, Clams, " +
                    "Grass, Bamboo, Clam Shell, Palm Fronds, Banana Leaves, Privet, Driftwood, " +
                    "Shore, Ancient Pier",
                Accessible = false,
                ExperiencePoints = 20
            },

            new IslandLocation
            {
                CommonName = "Shipwreck Lagoon",
                IslandLocationID = 4,
                Description = "Shipwreck Lagoon is located on Shipwreck Island, northeast of Deep Jungle and east of Pier Beach. " +
                              "Here you see reminants of your shipwrecked boat, crashed into the shoreline. " +
                              "Perhaps you could salvage some supplies from it. ",
                GeneralContents = "Coconuts, Raspberries, Bananas, Cherries, Almonds, Fish, Clams, " +
                    "Driftwood, Softwood, Palm Fronds, Nautilus Shell, Bamboo, Snowberries, Cowry Shell, Cockle Shell, " +
                    "Shore, Workbench, Ship",
                Accessible = false,
                ExperiencePoints = 10
            },
            #endregion

            #region Airplane Island
            new IslandLocation
            {
                CommonName = "West Beach",
                IslandLocationID = 5,
                Description = "West Beach is located west of Pier Beach, on Airplane Island. " +
                              "" +
                              "",
                GeneralContents = "Cherries, Soybeans, Taro, Papayas, Ginger, Yams, Bell Peppers, Coconuts, Yellow Hibiscus, Fish, " +
                    "Soft Wood, Palm Fronds, Grass, Clams (Gold Jade, Pearls), Driftwood, Shells, Messages in a Bottle, Stones, " +
                    "Workbench, Shore, Lost Crew Members",
                Accessible = false,
                ExperiencePoints = 10
            },
            new IslandLocation
            {
                CommonName = "Airplane Jungle",
                IslandLocationID = 6,
                Description = "Airplane Jungle is located west of West Beach, on Airplane Island. " +
                              "" +
                              "",
                GeneralContents = "Manicheel Fruit, Coconuts, Bananas, Guarana, Orange Hibiscus, Red Hibiscus, White Hibiscus, Papaya, Cucumbers, Sugarcane, " +
                    "Ti Leaves, Hardwood, Softwood, Okume Tree, Vines, Rattan, Palm Fronds, Banana Leaves, Bamboo, Mandrake Root, Indigo Leaves, Manchineel, Airplane Radio, " +
                    "Monkeys, Parrots",
                Accessible = false,
                ExperiencePoints = 10
            },
            new IslandLocation
            {
                CommonName = "Dark Cave",
                IslandLocationID = 7,
                Description = "Dark Cave is located north of Airplane Jungle and West Beach, on Airplane Island. " +
                              "" +
                              "",
                GeneralContents = "Fish" +
                    "Stones, Treasure Chest (Radio Transmitter)" +
                    "Pond",
                Accessible = false,
                ExperiencePoints = 10
            }
            #endregion

        };
    }
}
