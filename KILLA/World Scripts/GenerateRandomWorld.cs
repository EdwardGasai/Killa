using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;


//This class will generate a random world with a random population
public class GenerateRandomWorld : MonoBehaviour
{
    //Files we want to use to generate our world
    private string maleNamesFile = @"\FirstAndLastNames.csv";
    public int minPopulationSize;
    public int maxPopulationSize;
    public void createRandomWorld(int minPopSize, int maxPopSize)
    {
        World world = new World();
        //For now we will set our max population size to 5,000
        //This means we should have around 75 first/last names for each sex.

        //Check for max and min world size, reset if too low or high
        if(maxPopSize > 5000)
        {
            maxPopSize = 5000;
        }
        if(minPopSize < 100)
        {
            minPopSize = 100;
        }
        //Generate the Characters with their character data
        generateRandomCharacterPopulation(world, minPopSize, maxPopSize);
    }

    //Generate characters from the file path to a certain world
    private void generateRandomCharacterPopulation(World world, int minPopSize, int maxPopSize)
    {
        //Create a new list to hold our characters
        List<Character> characters = new List<Character>();

        //Generate Random Population Size
        int worldPopulationSize = Random.Range(minPopSize, maxPopSize);

        //List of first names
        List<string> maleFirstNames = new List<string>();
        List<string> femaleFirstNames = new List<string>();

        //List of Last Names
        List<string> maleLastNames = new List<string>();
        List<string> femaleLastNames = new List<string>();

        //Tracker of our current index in a list
        //Created out here to save on loading time
        int index;

        //List of Sexes
        List<string> sexes = new List<string> { "M", "F" };

        //Generate new characters for the world
        for (int i = 0; i < worldPopulationSize; i++)
        {
            //Create new Character and Character Data object
            Character c = new Character();
            CharacterData c_Data = new CharacterData();

            //Assign a random sex
            index = Random.Range(0, sexes.Count());
            //Set a random sex
            c_Data.sex = sexes[index];
            //Set their ID to the order they were created
            c_Data.id = i + 1;
            //Make sure no one spawns in dead
            c_Data.isDead = false;
            //Give everyone a random fighting capability
            c_Data.fightingCapability = Random.Range(0.0f, 100.0f);
            //Give everyone a random age
            c_Data.age = Random.Range(18, 125);
            //If it is a male set 
            if (c_Data.sex == "M")
            {
                //get a random first name from the list and place it 
                index = Random.Range(0, maleFirstNames.Count());
                c_Data.firstName = maleFirstNames[index];
                //get a random last name from the list and place it
                index = Random.Range(0, maleLastNames.Count());
                c_Data.lastName = maleLastNames[index];
            }
            else
            {
                //get a random first name from the list and place it 
                index = Random.Range(0, femaleFirstNames.Count());
                c_Data.firstName = femaleFirstNames[index];
                //get a random last name from the list and place it
                index = Random.Range(0, femaleLastNames.Count());
                c_Data.lastName = femaleLastNames[index];
            }
        }
        //Now that we have our Characters with their data,
        //we want to add their relationships.

    }

    private void generateRandomCharacterRelationsForPopulaiton(List<Character> population)
    {
        CharacterData cData;
        //for every character we want to assign their relationships
        //Character can have anywhere between 3 to 100 friends
        int maxfriends = 100;
        int minfriends = 3;
        //Index for our random variable, created here to save resources
        int index;
        //Character for our random variable, created here to save resources
        Character newRelationCharacter;

        //Add a relationship for every Character c
        foreach (Character c in population)
        {
            //get our character data;
            cData = c.data;

            if (cData.relationships.Count() >= maxfriends)
            {
                //Dont add anymore relationships to this character    
            }
            else if(c.data.relationships.Count() < minfriends)
            {
                //Make sure we add a relationship to this character, go down the
                //list until we hit a character returning our max
                
            }
            else
            {
                index = Random.Range(0, population.Count());
                //This gets a character from the random index in the population
                newRelationCharacter = population[index];
                //Now we make sure the random person we got isn't breaking
                //their limits by being added.
                //If and only if they're not
                if (exceedsRelationshipLimits(newRelationCharacter.data, maxfriends) == false)
                {
                    //we add the relation ship with a random value to their index;
                    //Create new relationship
                    Relationship newRelationship = new Relationship();
                    //Create the new realtionship data
                    RelationshipData newData = new RelationshipData();
                }
            }
        }
    }


    //Used to generate random relationshipData()
    private void generateRandomRelationshipData(RelationshipData data)
    {
       //We're gonna have a way to calculate the total relatinship gain
       //from an interaction

    }

    /*
    private float calculateRelationshipGain(data)
    {
        float relationshipGain;
        


        return relationshipGain;
    }
    */

    //Check if the character we are trying to add is not breaking it's bounds by adding
    private bool exceedsRelationshipLimits(CharacterData data, int max)
    {
        if (data.relationships.Count() >= max)
            return true;
        else
            return false;
  
    }
    private void getNamesFromFile(string filePath, List<string> firstNames, List<string> lastNames)
    {
        bool endOfFile = false;
        //Get the appPath on the computer
        string appPath = Application.dataPath;
        //Read from the named File
        StreamReader strReader = new StreamReader(appPath + filePath);
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
            firstNames.Add(names[0].ToString());
            //Add last name to list of last names
            lastNames.Add(names[1].ToString());


            Debug.Log("First Name: " + names[0] + "Last Name: " + names[1]);
        }
    }
}
