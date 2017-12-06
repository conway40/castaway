using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    public class Animal : Npc, IScavenge
    {
        public override int Id { get; set; }
        public override string Description { get; set; }

        //public List<SurvivorObject> scavengerObjects = new List<SurvivorObject>()
        //{
        //    new SurvivorObject
        //    {
        //        Id = 100,
        //        Name = "Papayas",
        //        IslandLocationId = 8,
        //        Description = "A tropical fruit.",
        //        Type = SurvivorObjectType.Food,
        //        Value = 0,
        //        CanInventory = true,
        //        IsConsumable = true,
        //        IsVisible = true,
        //        ExperiencePoints = 10,
        //        HealthPoints = 0
        //    },
        //    new SurvivorObject
        //    {
        //        Id = 101,
        //        Name = "Yams",
        //        IslandLocationId = 8,
        //        Description = "An earthy vegetable.",
        //        Type = SurvivorObjectType.Food,
        //        Value = 0,
        //        CanInventory = true,
        //        IsConsumable = true,
        //        IsVisible = true,
        //        ExperiencePoints = 10,
        //        HealthPoints = 0
        //    },
        //    new SurvivorObject
        //    {
        //        Id = 102,
        //        Name = "Coconuts",
        //        IslandLocationId = 8,
        //        Description = "A small, round coconut.",
        //        Type = SurvivorObjectType.Food,
        //        Value = 0,
        //        CanInventory = true,
        //        IsConsumable = true,
        //        IsVisible = true,
        //        ExperiencePoints = 10,
        //        HealthPoints = 0
        //    },
        //    new SurvivorObject
        //    {
        //        Id = 103,
        //        Name = "Soybeans",
        //        IslandLocationId = 8,
        //        Description = "A handful of soybeans.",
        //        Type = SurvivorObjectType.Food,
        //        Value = 0,
        //        CanInventory = true,
        //        IsConsumable = true,
        //        IsVisible = true,
        //        ExperiencePoints = 10,
        //        HealthPoints = 0
        //    },
        //    new SurvivorObject
        //    {
        //        Id = 104,
        //        Name = "Bell Pepper",
        //        IslandLocationId = 8,
        //        Description = "A green bell-shaped pepper.",
        //        Type = SurvivorObjectType.Food,
        //        Value = 0,
        //        CanInventory = true,
        //        IsConsumable = true,
        //        IsVisible = true,
        //        ExperiencePoints = 10,
        //        HealthPoints = 0
        //    },
        //    new SurvivorObject
        //    {
        //        Id = 105,
        //        Name = "Bass",
        //        IslandLocationId = 8,
        //        Description = "A 11 inch Bass fish.",
        //        Type = SurvivorObjectType.Fish,
        //        Value = 0,
        //        CanInventory = true,
        //        IsConsumable = true,
        //        IsVisible = true,
        //        ExperiencePoints = 10,
        //        HealthPoints = 0
        //    },
        //    new SurvivorObject
        //    {
        //        Id = 106,
        //        Name = "Trout",
        //        IslandLocationId = 8,
        //        Description = "An 8 inch Trout fish.",
        //        Type = SurvivorObjectType.Fish,
        //        Value = 0,
        //        CanInventory = true,
        //        IsConsumable = true,
        //        IsVisible = true,
        //        ExperiencePoints = 10,
        //        HealthPoints = 0
        //    },
        //    new SurvivorObject
        //    {
        //        Id = 107,
        //        Name = "Driftwood",
        //        IslandLocationId = 8,
        //        Description = "A piece of water-worn wood.",
        //        Type = SurvivorObjectType.CraftingItem,
        //        Value = 0,
        //        CanInventory = true,
        //        IsConsumable = false,
        //        IsVisible = true,
        //        ExperiencePoints = 10,
        //        HealthPoints = 0
        //    }
        //};

        public SurvivorObject ScavengeForObjects(List<SurvivorObject> scavengerObjects)
        {
            scavengerObjects = new List<SurvivorObject>();
            SurvivorObject foundObject = new SurvivorObject();
            Random rnd = new Random();
            if (scavengerObjects.Count > 0)
            {
                int scavengerObjectId = rnd.Next(1, scavengerObjects.Count);
                foundObject = scavengerObjects[scavengerObjectId];
            }

            return foundObject;
        }
    }
}
