<<<<<<< HEAD
﻿// Jovann Contreras
// Date 10/19/2022
// Letting the user choose between three options of food and give them a random resturant to eat at.
=======
﻿//Peer Reviewed By: Kenneth Fujimura
//Everything looks good to me. Everything works without any bugs that I could find. The input validation works well. I liked how you were using the .Length function to set some of the parameters. That kind of thing is really good so in case you wanted to add more data in the future, it will require a lot less editing your code to accomodate it. Very good practice. The only thing I would change is:
//- In the instructions, make it very clear what kind of input you want. Like telling the player to type the categories exactly as you wrote them. That's not totally necessary, but it's always good form to try and make your intructions to your users as clear as possible.
//- Make sure you're following the submission guidelines. You're missing the comment information at the top of your VS Code.
//But yeah, great job, man!
>>>>>>> ca31890184be8fe952ccb625650357a29da7c5d2

Console.Clear();
string[] Res = { "Chili's", "Sizzlers", "BJ's", "Olive Garden", "Outback", "Apple Bee's", "Payters", "Cheesecake Factory", "Texas Roadhouse", "Captain Crab" };
string[] FastFood = { "Mcdonalds", "Burger King", "Subway", "Carls.Jr", "Wendy's", "Philly CheeseStake", "Jack in box", "Canes", "Chic Fil a", "PopEyes" };
string[] Dessert = { "Basken Robins", "DF DONUTS & Coffee", "Dream Ice Cream Parlor", "Milk and Dream", "Bambu Desserts & Drinks", "Cold Stone Creamery", "Yogurtland", "85C Bakery Cafe", "Tigers Yogurt", "Start Donuts" };

string playerInput;

string tryAgain = "yes";
while (tryAgain == "yes")
{
    Console.WriteLine("Choose between Restaurant, FastFood or Dessert");

    playerInput = Console.ReadLine().ToLower();
    while (playerInput != "restaurant" && playerInput != "fastfood" && playerInput != "dessert")
    {
        Console.WriteLine("Invalid pick");
        Console.WriteLine("Choose between those 3 items");
        playerInput = Console.ReadLine().ToLower();
    }
    Console.WriteLine("You Picked " + playerInput);

    Random random = new Random();
    if (playerInput == "restaurant")
    {
        int index = random.Next(Res.Length);
        Console.WriteLine($"resTaurant: {Res[index]}");
    }
    else if (playerInput == "fastfood")
    {
        int index = random.Next(FastFood.Length);
        Console.WriteLine($"fastFood: {FastFood[index]}");
    }
    else if (playerInput == "dessert")
    {
        int index = random.Next(Dessert.Length);
        Console.WriteLine($"Dessert: {Dessert[index]}");
    }

   

    string playAgainInput = "Nothing";

    while (playAgainInput != "yes" || playAgainInput != "no")
    { 
        Console.WriteLine("Would you like to try again? type in Yes to retry or No to quit");
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