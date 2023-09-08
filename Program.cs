// See https://aka.ms/new-console-template for more information


{
    // A string list initialized with game titles.
    List<string> games = new List<string>
    {
        "CS:GO",
        "Halo 3",
        "Borderlands 3",
        "Fifa 22",
        "Minecraft",
    };

    // An array of strings thats initialized with two more games.
    string[] otherGame = new string[]
    {
        "Tiny Tina's WonderLands",
        "Farcry 3",
    };

    // A foreach loop that prints each game in the list.
    foreach(string game in games)
    {
        Console.WriteLine(game);
    }

    // Prints to console the number of items in the list.
    Console.WriteLine($"\nGame in list: {games.Count}");

    games.AddRange(otherGame);

    Console.WriteLine($"\nGame in list: {games.Count}");

    // prints to console, "MASTER CHIEF is in the house!".
    if (games.Contains("Halo"))
    {
        Console.WriteLine("\nMASTER CHIEF IS IN THE HOUSE!!");
    }
    else
    {
        games.Add("Halo");
    }

    // An int assigned to the value of 6 for 6 of the games.
    int myInt = 6;
    if(myInt < games.Count)
    {
        games.RemoveAt(myInt);
    }
    else
    {
        Console.WriteLine("\nGame not found!");
    }

    // Print to console, "All games in the list:"
    Console.WriteLine("\nAll games in the lst:");
    foreach (string game in games)
    {
        Console.WriteLine(game);
    }
    // Sorts the games list.
    games.Sort();
    Console.WriteLine("\nSorted games lst:");
    foreach (string game in games)
    {
        Console.WriteLine(game);
    }

    string[] newList = new string[games.Count];

    // Copys the games list to the string array newList.
    games.CopyTo(newList);

    // Clears the games list.
    games.Clear();

    // Prints each of the strings in the new list.
    Console.WriteLine("\nNew List:");
    foreach(string game in newList)
    {
        Console.WriteLine(game);
    }
}

