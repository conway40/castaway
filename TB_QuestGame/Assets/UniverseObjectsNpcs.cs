using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    public static partial class UniverseObjects
    {


        public static int GenerateRandomExperiencePoints()
        {
            Random rnd = new Random();
            int xp = rnd.Next(1, 40);
            return xp;
        }

        public static int GenerateRandomHealthPoints()
        {
            Random rnd = new Random();
            int health = rnd.Next(1, 20);
            return health;
        }

        public static int GenerateRandomLives()
        {
            Random rnd = new Random();
            int lives = rnd.Next(1, 5);
            return lives;
        }

        public static List<Npc> Npcs = new List<Npc>()
        {
            new CrewMember
            {
                Id = 1,
                Name = "Bella Goth",
                IslandLocationID = 3,
                Description = "A skinny, dark-haired woman dressed in a red, ragged dress.",
                Messages = new List<string>
                {
                    "Hey, you! Thank god you found me. I'm so glad you're alive!",
                    "Can you see that island over there? I've been thinking we could fix up this pier and sail to it.",
                    "Do you know how to build a canoe? I think we'd need a log, a chisel, and some paddles."
                },
                ExperiencePoints = GenerateRandomExperiencePoints(),
                Health = GenerateRandomHealthPoints(),
                Lives = GenerateRandomLives()
            },

            new CrewMember
            {
                Id = 2,
                Name = "Bob Newbie",
                IslandLocationID = 5,
                Description = "A bald, bearded man, dressed in only cutoff shorts.",
                Messages = new List<string>
                {
                    "Oh my, I thought I'd never see anyone again!",
                    "I was going to look in that jungle, but I can't make it through the brush and vines.",
                    "If only we had a way off of this island. Maybe we could catch the attention of passing ships or airplanes."
                },
                ExperiencePoints = GenerateRandomExperiencePoints(),
                Health = GenerateRandomHealthPoints(),
                Lives = GenerateRandomLives()
            },

            new Animal
            {
                Id = 3,
                Name = "Monkey",
                IslandLocationID = 1,
                Description = "A monkey.",
            }

        };
    }
}
