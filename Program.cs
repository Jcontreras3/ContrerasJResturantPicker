
Console.Clear();
string[] Res = { "Chili's", "Sizzlers", "BJ's", "Olive Garden", "Outback", "Apple Bee's", "Payters", "Cheesecake Factory", "Texas Roadhouse", "Captain Crab" };
string[] FastFood = { "Mcdonalds", "Burger King", "Subway", "Carls.Jr", "Wendy's", "Philly CheeseStake", "Jack in box", "Canes", "Chic Fil a", "PopEyes" };
string[] Dessert = { "Basken Robins", "DF DONUTS & Coffee", "Dream Ice Cream Parlor", "Milk and Dream", "Bambu Desserts & Drinks", "Cold Stone Creamery", "Yogurtland", "85C Bakery Cafe", "Tigers Yogurt", "Start Donuts" };

string playerInput;

string tryAgain = "yes";
while (tryAgain == "yes")
{
    Console.WriteLine("Choose between food, drink or dessert");

    playerInput = Console.ReadLine().ToLower();
    while (playerInput != "food" && playerInput != "drink" && playerInput != "dessert")
    {
        Console.WriteLine("Invalid pick");
        Console.WriteLine("Choose between those 3 items");
        playerInput = Console.ReadLine().ToLower();
    }
    Console.WriteLine("You Picked " + playerInput);

    Random random = new Random();
    if (playerInput == "Resturant")
    {
        int index = random.Next(Res.Length);
        Console.WriteLine($"Food: {Res[index]}");
    }
    else if (playerInput == "FastFood")
    {
        int index = random.Next(FastFood.Length);
        Console.WriteLine($"Drink: {FastFood[index]}");
    }
    else if (playerInput == "dessert")
    {
        int index = random.Next(Dessert.Length);
        Console.WriteLine($"Dessert: {Dessert[index]}");
    }

    Console.WriteLine("Would you like to try again? type in Yes to retry or No to quit");

    string playAgainInput = "Nothing";

    while (playAgainInput != "yes" || playAgainInput != "no")
    {
        playAgainInput = Console.ReadLine().ToLower();
        if (playAgainInput == tryAgain)
        {
            break;
        }
        else if (playAgainInput == "no")
        {
            Console.WriteLine("Thanks for playing!");
            tryAgain = playAgainInput;
            break;

        }
        else
        {
            Console.WriteLine("Invalid input please type in Yes or No");
            playAgainInput = "invalid";
        }


    }
}