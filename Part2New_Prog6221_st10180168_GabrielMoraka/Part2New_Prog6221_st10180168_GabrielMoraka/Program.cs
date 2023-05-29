using System;
using static Part2New_Prog6221_st10180168_GabrielMoraka.Functions;
using static Part2New_Prog6221_st10180168_GabrielMoraka.Functions.Recipe;

namespace Part2New_Prog6221_st10180168_GabrielMoraka
{

    //This is the main class for the recipe
    class Program
    {
        static void Main(string[] args)
        {

            MethodsAndFunctions recipe = new MethodsAndFunctions();
            while (true)
            {

                //This is the full menu 
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("********************************* The Menu *********************************\n" +
                    "Press 1 to enter a new recipe ");
                Console.WriteLine("Press 2 to display the list of recipes");
                Console.WriteLine("Press 3 to clear recipe");
                Console.WriteLine("Press 4 to exit\n" +
                    "********************************************************************");
                Console.ResetColor();


                // Using the switch case method to prompt the user to select a number in the menu
                string selection = Console.ReadLine();
                switch (selection)
                {
                    //using the switch case to call the methods

                    case "1":
                        recipe.TheNewRecipe();
                        break;
                    case "2":
                        recipe.fullDisplay();
                       
                        break;
                   
                    case "3":
                        recipe.ClearTheRecipe();
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("The program is exiting...");
                        Console.ResetColor();
                        return;

                    default:
                        Console.WriteLine("Invalid option. Try again");
                        break;
                }
            }
        }
    }
}