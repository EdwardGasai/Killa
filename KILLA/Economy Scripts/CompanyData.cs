using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanyData : ScriptableObject
{
    //The company name
    public string CompanyName;
    //The company employees
    public List<Character> Employees;
    //The company stocks
    public List<Stock> Stocks;
    //The compnaies total money, calculated based on employees, stock and time passed
    public int TotalMoney;
    //Are they bankrupt?
    public bool IsBankrupt;
}
