using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// enum of all possible player actions
    /// </summary>
    public enum SurvivorAction
    {
        None,
        MissionSetup,
        LookAround,
        Travel,

        SurvivorMenu,
        SurvivorInfo,
        Inventory,
        SurvivorLocationsVisited,

        ObjectMenu,
        LookAt,
        PickUp,
        PutDown,
        InteractWith,

        NonplayerCharacterMenu,
        TalkTo,
        AskToScavenge,

        AdminMenu,
        ListIslandLocations,
        ListGameObjects,
        ListNonplayerCharacters,
        SurvivorEditInfo,

        ReturnToMainMenu,
        Exit
    }
}
