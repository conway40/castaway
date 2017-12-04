using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    public class CrewMember : Npc, ISpeak
    {
        public override int Id { get; set; }
        public override string Description { get; set; }
        public List<string> Messages { get; set; }
        private int _experiencePoints;
        private int _health;
        private int _lives;
        private int _keys;

        public int Keys
        {
            get { return _keys; }
            set { _keys = value; }
        }


        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }


        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }


        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set { _experiencePoints = value; }
        }


        /// <summary>
        /// generate a message or use default
        /// </summary>
        /// <returns>message text</returns>
        public string Speak()
        {
            if (this.Messages != null)
            {
                return GetMessage();
            }
            else
            {
                return $"My name is {base.Name}.";
            }
        }

        /// <summary>
        /// randomly select a message from the list of messages
        /// </summary>
        /// <returns>message text</returns>
        private string GetMessage()
        {
            Random r = new Random();
            int messageIndex = r.Next(0, Messages.Count());
            return Messages[messageIndex];
        }
    }
}
