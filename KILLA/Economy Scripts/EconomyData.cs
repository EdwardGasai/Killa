using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomyData : ScriptableObject
{
    //Each economy has a total amount of money
    public int WorldEconomyTotal;
    //Each economy has a list of companies within it
    public List<Company> Companies;
    //Each economy has a list of stocks
    public List<Stock> Stocks;
}
