using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    interface IScavenge
    {
        //List<SurvivorObject> scavengerObjects { get; set; }

        SurvivorObject ScavengeForObjects(List<SurvivorObject> scavengerObjects);
    }
}
