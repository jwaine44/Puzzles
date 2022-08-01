// Create a function called RandomArray() that returns an integer array

// Create an empty array that will hold 10 integer values.  
// Loop through the array and assign each index a random integer value between 5 and 25. 
// Print the min and max values of the array
// Print the sum of all the values

static int[] RandomArray()
{
    Random rand = new Random();
    int[] numArray = new int[10];
    int max = 25;
    int min = 5;
    int sum = 0;
    for(int i = 0; i < numArray.Length; i++)
    {
        numArray[i] = rand.Next(5, 26);

        if(max > numArray[i])
        {
            max = numArray[i];
        }

        if(min < numArray[i])
        {
            min = numArray[i];
        }

        sum += numArray[i];
    }
    Console.WriteLine(max);
    Console.WriteLine(min);
    Console.WriteLine(sum);
    return numArray;
}

RandomArray();

// Create a function called TossCoin() that returns a string

// Have the function print "Tossing a Coin!"
// Randomize a coin toss with a result signaling either side of the coin
// Have the function print either "Heads" or "Tails"
// Finally, return the result

static string TossCoin()
{
    Console.WriteLine("Tossing a Coin!");
    Random rand = new Random();
    int coinToss = rand.Next(0, 2);
    string result = "";
    if(coinToss == 0)
    {
        result = "Heads";
    }
    if(coinToss == 1)
    {
        result = "Tails";
    }
    return result;
}

string tossCoinResult;
tossCoinResult = TossCoin();
Console.WriteLine(tossCoinResult);

// Build a function Names that returns a list of strings.
// Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
// Return a list that only includes names longer than 5 characters

static List<string> Names()
{
    List<string> nameList = new List<string>();
    nameList.Add("Todd");
    nameList.Add("Tiffany");
    nameList.Add("Charlie");
    nameList.Add("Geneva");
    nameList.Add("Sydney");

    List<string> resultList = new List<string>();

    for(var idx = 0; idx < nameList.Count; idx++)
    {
        if(nameList[idx].Length > 5)
        {
            resultList.Add(nameList[idx]);
        }
    }
    foreach(var i in resultList)
    {
        Console.WriteLine(i);
    }
    return resultList;
}

Console.WriteLine(Names());