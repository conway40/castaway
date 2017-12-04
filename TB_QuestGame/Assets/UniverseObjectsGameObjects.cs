using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
	public static partial class UniverseObjects
	{
        public static List<GameObject> gameObjects = new List<GameObject>()
        {
            #region Initial Inventory Objects
            new SurvivorObject
            {
                Id = 1,
                Name = "Torn T-Shirt",
                IslandLocationId = 0,
                Description = "The t-shirt you were wearing when you washed up on shore. It is torn and dirty.",
                Type = SurvivorObjectType.Clothing,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 0,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 2,
                Name = "Coconut",
                IslandLocationId = 0,
                Description = "A small, round coconut.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 0,
                HealthPoints = 10
            },
            #endregion

            #region First Beach Objects
            new SurvivorObject
            {
                Id = 3,
                Name = "Coconut",
                IslandLocationId = 1,
                Description = "A small, round coconut.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 4,
                Name = "Clam",
                IslandLocationId = 1,
                Description = "A palm-sized clam shell, with clam meat inside.",
                Type = SurvivorObjectType.Fish,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 5,
                Name = "Mackerel",
                IslandLocationId = 1,
                Description = "A 10 inch Mackerel fish.",
                Type = SurvivorObjectType.Fish,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 6,
                Name = "Sardine",
                IslandLocationId = 1,
                Description = "A 5 inch Sardine.",
                Type = SurvivorObjectType.Fish,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 5,
                HealthPoints = 5
            },
            new SurvivorObject
            {
                Id = 7,
                Name = "Driftwood",
                IslandLocationId = 1,
                Description = "A piece of wet, water-worn wood.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 10,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 8,
                Name = "Bamboo",
                IslandLocationId = 1,
                Description = "A bamboo reed.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 30,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 9,
                Name = "Nautilus Shell",
                IslandLocationId = 1,
                Description = "A striped, spiral-shaped shell.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 10,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 10,
                Name = "Large Clam Shell",
                IslandLocationId = 1,
                Description =
                    "A large, empty clam shell.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 11,
                Name = "Palm Frond",
                IslandLocationId = 1,
                Description =
                    "A leaf from a palm tree.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new InteractiveObject
            {
                Id = 12,
                Name = "Fire Pit",
                IslandLocationId = 1,
                Description =
                    "A pile of dirt and ashes. It looks like someone built a fire here recently...",
                Type = InteractiveObjectType.Firepit,
                RequiresInventoryItems = true
            },
            new InteractiveObject
            {
                Id = 13,
                Name = "Work Bench",
                IslandLocationId = 1,
                Description =
                    "A palm tree stump, with a flat surface. A perfect place to craft items on.",
                Type = InteractiveObjectType.Workbench,
                RequiresInventoryItems = true
            },
            new InteractiveObject
            {
                Id = 14,
                Name = "Shore",
                IslandLocationId = 1,
                Description =
                    "Where the sand meets the sea. You could bathe here, or fish if you had something to catch fish with.",
                Type = InteractiveObjectType.WaterBody,
                RequiresInventoryItems = true
            },
            #endregion

            #region Deep Jungle Objects
            new SurvivorObject
            {
                Id = 15,
                Name = "Banana",
                IslandLocationId = 2,
                Description = "A ripe, yellow banana.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 16,
                Name = "Long Beans",
                IslandLocationId = 2,
                Description = "A handfull of green, yard-long beans.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 17,
                Name = "Rumberries",
                IslandLocationId = 2,
                Description = "A handfull of round, dark red berries.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 18,
                Name = "Star Fruit",
                IslandLocationId = 2,
                Description = "A star-shaped fruit.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 19,
                Name = "Cucumber",
                IslandLocationId = 2,
                Description = "A long, green vegetable.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 20,
                Name = "Snowberries",
                IslandLocationId = 2,
                Description = "A handfull of round, white berries.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 0,
                HealthPoints = -5
            },
            new SurvivorObject
            {
                Id = 21,
                Name = "Almonds",
                IslandLocationId = 2,
                Description = "A handfull of oval-shaped nuts.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 22,
                Name = "Vines",
                IslandLocationId = 2,
                Description = "A handfull of long, thin vines.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 23,
                Name = "Banana Leaf",
                IslandLocationId = 2,
                Description = "A leaf from a banana tree.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 24,
                Name = "Hardwood",
                IslandLocationId = 2,
                Description = "A log of hard, sturdy wood.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            #endregion

            #region Pier Beach Objects
            new SurvivorObject
            {
                Id = 25,
                Name = "Coconut",
                IslandLocationId = 3,
                Description = "A round coconut.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 26,
                Name = "Banana",
                IslandLocationId = 3,
                Description = "A ripe, yellow banana.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 27,
                Name = "Ginger",
                IslandLocationId = 3,
                Description = "A piece of ginger root.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 5
            },
            new SurvivorObject
            {
                Id = 28,
                Name = "Blackberries",
                IslandLocationId = 3,
                Description = "A handfull of oval-shaped, black berries.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 29,
                Name = "Almonds",
                IslandLocationId = 3,
                Description = "A handful of oval-shaped nuts.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 30,
                Name = "Parrot Fish",
                IslandLocationId = 3,
                Description = "A 12 inch parrot fish.",
                Type = SurvivorObjectType.Fish,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 31,
                Name = "Speckled Grouper",
                IslandLocationId = 3,
                Description = "A 9 inch Speckled Grouper fish.",
                Type = SurvivorObjectType.Fish,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 32,
                Name = "Yellowtail Rockfish",
                IslandLocationId = 3,
                Description = "A 15 inch Yellowtail Rockfish.",
                Type = SurvivorObjectType.Fish,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 20
            },
            new SurvivorObject
            {
                Id = 33,
                Name = "Clam",
                IslandLocationId = 3,
                Description = "A clam shell with clam meat inside.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 10
            },
            new SurvivorObject
            {
                Id = 34,
                Name = "Grass",
                IslandLocationId = 3,
                Description = "A handfull of long, green grass.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 35,
                Name = "Bamboo",
                IslandLocationId = 3,
                Description = "A few bamboo reeds.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 36,
                Name = "Clam Shell",
                IslandLocationId = 3,
                Description = "An empty clam shell.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 37,
                Name = "Palm Frond",
                IslandLocationId = 3,
                Description = "A leaf from a palm tree.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 38,
                Name = "Banana Leaf",
                IslandLocationId = 3,
                Description = "A leaf from a banana tree.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 39,
                Name = "Privet Leaves",
                IslandLocationId = 3,
                Description = "A handfull of privet leaves. You could eat these to treat an upset stomach.",
                Type = SurvivorObjectType.Food,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 50
            },
            new SurvivorObject
            {
                Id = 40,
                Name = "Driftwood",
                IslandLocationId = 3,
                Description = "A piece of wet, water-worn wood.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 10,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new InteractiveObject
            {
                Id = 41,
                Name = "Shore",
                IslandLocationId = 3,
                Description = "Where the sand meets the sea. You could bathe here, or fish if you had something to catch fish with.",
                Type = InteractiveObjectType.WaterBody,
                RequiresInventoryItems = true
            },
            new InteractiveObject
            {
                Id = 42,
                Name = "Ancient Pier",
                IslandLocationId = 3,
                Description = "An old, weather-beaten, broken pier. You could fix this up and use it to sail to the island you can see in the distance.",
                Type = InteractiveObjectType.Pier,
                RequiresInventoryItems = true
            },

            #endregion

            #region Shipwreck Lagoon Objects
            new SurvivorObject
            {
                Id = 43,
                Name = "Coconuts",
                IslandLocationId = 4,
                Description = "A small, round coconut.",
                Type = SurvivorObjectType.Food,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 44,
                Name = "Raspberries",
                IslandLocationId = 4,
                Description = "A handful of small, red berries.",
                Type = SurvivorObjectType.Food,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 45,
                Name = "Bananas",
                IslandLocationId = 4,
                Description = "A yellow banana.",
                Type = SurvivorObjectType.Food,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 46,
                Name = "Cherries",
                IslandLocationId = 4,
                Description = "A handful of red cherries.",
                Type = SurvivorObjectType.Food,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 47,
                Name = "Almonds",
                IslandLocationId = 4,
                Description = "A handful of oval-shaped nuts.",
                Type = SurvivorObjectType.Food,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 48,
                Name = "Fish",
                IslandLocationId = 4,
                Description = "A fish.",
                Type = SurvivorObjectType.Fish,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 49,
                Name = "Fish",
                IslandLocationId = 4,
                Description = "A fish.",
                Type = SurvivorObjectType.Fish,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 50,
                Name = "Fish",
                IslandLocationId = 4,
                Description = "A fish.",
                Type = SurvivorObjectType.Fish,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 51,
                Name = "Clam",
                IslandLocationId = 4,
                Description = "A clam.",
                Type = SurvivorObjectType.Fish,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 0
            },

            new SurvivorObject
            {
                Id = 52,
                Name = "Driftwood",
                IslandLocationId = 4,
                Description = "A piece of water-worn wood.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },

            new SurvivorObject
            {
                Id = 53,
                Name = "Softwood",
                IslandLocationId = 4,
                Description = "A log of soft, carvable wood.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },

            new SurvivorObject
            {
                Id = 54,
                Name = "Palm Fronds",
                IslandLocationId = 4,
                Description = "A leaf from a palm tree.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 55,
                Name = "Nautilus Shell",
                IslandLocationId = 4,
                Description = "A circular-shaped shell.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 56,
                Name = "Bamboo",
                IslandLocationId = 4,
                Description = "Reeds of bamboo.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 57,
                Name = "Snowberries",
                IslandLocationId = 4,
                Description = "A handful of white berries.",
                Type = SurvivorObjectType.Food,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 58,
                Name = "Cockle Shell",
                IslandLocationId = 4,
                Description = "A wide, round shell.",
                Type = SurvivorObjectType.CraftingItem,

            },
            new InteractiveObject
            {
                Id = 59,
                Name = "Shore",
                IslandLocationId = 4,
                Description = "Where the sand meets the sea. You could bathe here, or fish if you had something to catch fish with.",
                Type = InteractiveObjectType.WaterBody,
                RequiresInventoryItems = true
            },
            new InteractiveObject
            {
                Id = 60,
                Name = "Workbench",
                IslandLocationId = 4,
                Description = "A palm tree stump, with a flat surface. A perfect place to craft items on.",
                Type = InteractiveObjectType.Workbench,
                RequiresInventoryItems = true
            },
            new InteractiveObject
            {
                Id = 61,
                Name = "Ship",
                IslandLocationId = 4,
                Description = "The destroyed wreckage of the ship you and your crew sailed on.",
                Type = InteractiveObjectType.Ship,
                RequiresInventoryItems = false
            },
            #endregion

            #region West Beach Objects
            new SurvivorObject
            {
                Id = 62,
                Name = "Papayas",
                IslandLocationId = 5,
                Description = "A tropical fruit.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 63,
                Name = "Yams",
                IslandLocationId = 5,
                Description = "An earthy vegetable.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 64,
                Name = "Coconuts",
                IslandLocationId = 5,
                Description = "A small, round coconut.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 65,
                Name = "Soybeans",
                IslandLocationId = 5,
                Description = "A handful of soybeans.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 66,
                Name = "Bell Pepper",
                IslandLocationId = 5,
                Description = "A green bell-shaped pepper.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 67,
                Name = "Fish",
                IslandLocationId = 5,
                Description = "A fish.",
                Type = SurvivorObjectType.Fish,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 68,
                Name = "Fish",
                IslandLocationId = 5,
                Description = "A fish.",
                Type = SurvivorObjectType.Fish,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 69,
                Name = "Driftwood",
                IslandLocationId = 5,
                Description = "A piece of water-worn wood.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 70,
                Name = "Grass",
                IslandLocationId = 5,
                Description = "A handfull of long grass.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 71,
                Name = "Softwood",
                IslandLocationId = 5,
                Description = "A log of soft, carvable wood.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new InteractiveObject
            {
                Id = 72,
                Name = "Workbench",
                IslandLocationId = 5,
                Description = "A palm tree stump, with a flat surface. A perfect place to craft items on.",
                Type = InteractiveObjectType.Workbench,
                RequiresInventoryItems = true
            },
            new InteractiveObject
            {
                Id = 73,
                Name = "Shore",
                IslandLocationId = 5,
                Description = "Where the sand meets the sea. You could bathe here, or fish if you had something to catch fish with.",
                Type = InteractiveObjectType.WaterBody,
                RequiresInventoryItems = true
            },
            
            #endregion

            #region Airplane Jungle Objects
            new SurvivorObject
            {
                Id = 74,
                Name = "Coconut",
                IslandLocationId = 6,
                Description = "A small, round coconut.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 75,
                Name = "Airplane Radio",
                IslandLocationId = 6,
                Description = "An airplane radio. No one can hear you without something to transmit the signal, though.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            
            #endregion

            #region Dark Cave Objects
            new SurvivorObject
            {
                Id = 76,
                Name = "Fish",
                IslandLocationId = 7,
                Description = "A fish.",
                Type = SurvivorObjectType.Fish,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 0
            },

            new SurvivorObject
            {
                Id = 77,
                Name = "Stones",
                IslandLocationId = 7,
                Description = "A small leather pouch filled with 9 gold coins.",
                Type = SurvivorObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },

            new InteractiveObject
            {
                Id = 78,
                Name = "Treasure Chest",
                IslandLocationId = 7,
                Description = "A small leather pouch filled with 9 gold coins.",
                Type = InteractiveObjectType.TreasureChest,
                RequiresInventoryItems = false
            },

            new SurvivorObject
            {
                Id = 79,
                Name = "Radio Transmitter",
                IslandLocationId = 7,
                Description = "A small leather pouch filled with 9 gold coins.",
                Type = SurvivorObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },

            new SurvivorObject
            {
                Id = 80,
                Name = "Pond",
                IslandLocationId = 7,
                Description = "A small leather pouch filled with 9 gold coins.",
                Type = SurvivorObjectType.Treasure,
                Value = 45,
                CanInventory = false,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },

            #endregion

            #region Scavenger Objects
            new SurvivorObject
            {
                Id = 100,
                Name = "Papayas",
                IslandLocationId = 8,
                Description = "A tropical fruit.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 101,
                Name = "Yams",
                IslandLocationId = 8,
                Description = "An earthy vegetable.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 102,
                Name = "Coconuts",
                IslandLocationId = 8,
                Description = "A small, round coconut.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 103,
                Name = "Soybeans",
                IslandLocationId = 8,
                Description = "A handful of soybeans.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 104,
                Name = "Bell Pepper",
                IslandLocationId = 8,
                Description = "A green bell-shaped pepper.",
                Type = SurvivorObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 105,
                Name = "Bass",
                IslandLocationId = 8,
                Description = "A 11 inch Bass fish.",
                Type = SurvivorObjectType.Fish,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 106,
                Name = "Trout",
                IslandLocationId = 8,
                Description = "An 8 inch Trout fish.",
                Type = SurvivorObjectType.Fish,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = false,
                ExperiencePoints = 10,
                HealthPoints = 0
            },
            new SurvivorObject
            {
                Id = 107,
                Name = "Driftwood",
                IslandLocationId = 8,
                Description = "A piece of water-worn wood.",
                Type = SurvivorObjectType.CraftingItem,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true,
                ExperiencePoints = 10,
                HealthPoints = 0
            },

#endregion
        };
	}
}
