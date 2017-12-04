using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    public class InteractiveObject : GameObject
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override int IslandLocationId { get; set; }
        public InteractiveObjectType Type { get; set; }
        public bool RequiresInventoryItems { get; set; }
    }
}
