using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class World : MonoBehaviour
{
    //Each world has it's data
    public WorldData W_Data;

    //Get the appPath on the computer
    string appPath = Application.dataPath;

    //Name of file containing First and Last Names
    private string NamesFile = @"\FirstAndLastNames.csv";
    private string MoodsFile = @"\Moods.csv";
    //List of moods the characters can have


    //List of names the characters can have, recieved from file
    private List<string> FirstNames;
    private List<string> LastNames;

    //Lists for our data recived from files
    public List<Mood> Moods;

    public void CreateWorld(int populationSize)
    {
        GenerateNewCharacterPopulation(W_Data.Characters, populationSize);
    }


    //Generate a random character population for the world characters list
    private void GenerateNewCharacterPopulation(List<Character> characters, int populationSize)
    {


        //Generate random character data until we reach our desired Population Size
        for (int i = 0; i < populationSize; i++)
        {
            //Create new Character with their character Data
            Character NewCharacter = new Character();
            CharacterData NewCharData = NewCharacter.CH_Data;
            //Character ID is assigned on creation
            NewCharData.ID = i + 1;


            //Set a random character name and assign it the new character
            NewCharData.FirstName = GetRandomName(FirstNames);
            NewCharData.LastName = GetRandomName(LastNames);

            //Log the character created in the debug
            Debug.Log("Character Generated:" + "\n ID: " + NewCharData.ID +
                                               "\n First Name: " + NewCharData.FirstName +
                                               "\n Last Name: " + NewCharData.LastName +
                                               "\n Mood: " + NewCharData.Mood);

        }


    }

    private string GetRandomName(List<string> Names)
    {
        //Get random index in the range of the Names list provided
        int index = Random.Range(0, Names.Count);
        //Get the name at that index
        string randomName = Names[index];
        //Return the random name
        return randomName;
    }

    private void GetNamesFromFile(string FilePath, List<string> FirstNames, List<string> lastNames)
    {
        bool endOfFile = false;

        //Read from the named File
        StreamReader strReader = new StreamReader(appPath + FilePath);
        //Generate Random buildings from their types
        //Create list of names to pick from for our characters, list comes from CSV file provided
        while (!endOfFile)
        {
            string dataString = strReader.ReadLine();
            if (dataString == null)
            {
                endOfFile = true;
                break;
            }
            var names = dataString.Split(',');
            //Add first name to list of first names
            FirstNames.Add(names[0].ToString());
            //Add last name to list of last names
            lastNames.Add(names[1].ToString());


            Debug.Log("First Name: " + names[0] + "Last Name: " + names[1]);
        }
    }

}
