using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




//Data for the killer

[CreateAssetMenu(menuName = "Killer Data")]
public class KillerData : CharacterData
{
    public bool hasAlibi;

    public int killCount;

    public List<string> crimes;

    public List<string> evidenceLeft;

    public int wantToKill;

    public List<string> victims;

    public List<string> preferredVictim;


}
