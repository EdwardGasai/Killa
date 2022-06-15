using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Player Data builds off the pretense that you too are a killer
public class PlayerData : KillerData
{

    //Our characters rank with the hunting lodge
    public string hunterRank;
    
    //0.0 to 100.0 How suscpicious the police are of you
    public float suscpicionFromPolice;

    //0.0 to 100.0 How normal you appear, visiting suspicious places and doing strange activities increases this
    public float normality;



}
