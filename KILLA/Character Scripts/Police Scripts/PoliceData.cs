using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceData : CharacterData
{
    [CreateAssetMenu(menuName = "Police Data")]
    public class KillerData : CharacterData
    {
        public List<string> killersCaught;

        public string rank;

        public List<string> evidenceCollectedAgainstKiller;

        public List<string> evidenceCollectedAgainstPlayer;

        public float wantToKill;

        public List<string> victims;

        public List<string> preferredVictim;


    }

}
