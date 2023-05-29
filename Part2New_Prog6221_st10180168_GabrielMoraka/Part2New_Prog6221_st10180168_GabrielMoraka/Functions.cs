using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Part2New_Prog6221_st10180168_GabrielMoraka.Functions;

namespace Part2New_Prog6221_st10180168_GabrielMoraka
{
    class Functions
    {

        public class Ingredient
        {

            // getters and setters delcaretions
            public string name { get; set; }
            public double quantities { get; set; }
            public string units { get; set; }
            public int calories { get; set; }
            public string foodGroup { get; set; }

        }




        public class Step
        {
            // getters and setters delcaretions
            public string description { get; set; }
        }


        public class Recipe
        {
            // getters and setters delcaretions
            public string name { get; set; }
            public List<Ingredient> Ingredients { get; set; }
            public List<Step> Steps { get; set; }


            // creating a method for sclaring the recipe
            public void scaleTheRecipe(int factor)
            {
                foreach (var ingredient in Ingredients)
                {
                    ingredient.quantities *= factor;
                }
            }








            public static List<Recipe> recipes = new List<Recipe>();



            public class MethodsAndFunctions
            {


                public string[] steps;




                public MethodsAndFunctions()
                {
                    // Initialize empty arrays for steps


                    steps = new string[0];

                }
                Recipe Recipe = new Recipe();
                private static int w;
                private static int sum;

                public void TheNewRecipe()
                {

                    Recipe recipe = new Recipe();

                    Console.WriteLine("Please enter a name for the New Recipe");
                    recipe.name = Console.ReadLine();
                    Console.WriteLine();

                    // This prompts the user to enter the number of ingredients
                    Console.Write("Enter the number of ingredients: ");
                    int numberOfIngredients = int.Parse(Console.ReadLine());



                    recipe.Ingredients = new List<Ingredient>();


                    // This is where the user enters the details for the recipe or the ingredient
                    for (int i = 0; i < numberOfIngredients; i++)
                    {
                        // creating a new arry list for ingredints
                        Ingredient ingredients = new Ingredient();


                        Console.WriteLine($"Enter details for ingredient #{i + 1}:");
                        Console.Write("Name: ");
                        // stores in arry list named ingredients
                        ingredients.name = Console.ReadLine();

                        Console.Write("Quantity: ");
                        // stores in arry list named ingredients
                        ingredients.quantities = int.Parse(Console.ReadLine());

                        Console.Write("Unit of measurement: ");
                        // stores in arry list named ingredients
                        ingredients.units = Console.ReadLine();

                        Console.Write("Please enter the amount of calories: ");
                        // stores in arry list named ingredients
                        ingredients.calories = int.Parse(Console.ReadLine());



                        Console.Write("Enter the food group for the ingredient: ");
                        // stores in arry list named ingredients
                        ingredients.foodGroup = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("The ingredient you entered has been successfully captured\n\n");
                        Console.ResetColor();

                        recipe.Ingredients.Add(ingredients);
                        Console.WriteLine();

                    }


                    recipe.Steps = new List<Step>();

                    // This is where the user enters the number of steps
                    Console.Write("Enter the number of steps: ");
                    int numberOfSteps = int.Parse(Console.ReadLine());

                    // Initialize the right size for the steps array
                    steps = new string[numberOfSteps];

                    // Prompt the user to enter the description in the steps
                    for (int i = 0; i < numberOfSteps; i++)
                    {
                        //creating an array list for step
                        Step step = new Step();

                        Console.Write($"Enter step #{i + 1}: ");
                        //values will be stored into array list step 
                        step.description = Console.ReadLine();


                        recipe.Steps.Add(step);
                        Console.WriteLine();
                    }

                    recipes.Add(recipe);


                    //changes the color of text
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("The recipe has been successfully captured\n\n");
                    Console.ResetColor();






                }








                // this is the method for displaying the recipe
                public void fullDisplay()
                {
                    {
                        if (recipes.Count == 0)
                        {
                            Console.WriteLine("There are no recipes entered.");
                        }
                        else
                        {
                            Console.WriteLine("Recipe or Recipes that have been entered:");
                            Console.WriteLine();

                            int i = 1;
                            foreach (var recipe in recipes.OrderBy(r => r.name))
                            {
                                Console.WriteLine($"{i}. {recipe.name}");
                                i++;
                            }

                            Console.WriteLine();

                            Console.Write("Choose a number to diplay the recipe you want: ");
                            int recipeNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            if (recipeNumber >= 1 && recipeNumber <= recipes.Count)
                            {
                                Recipe selectedRecipe = recipes.OrderBy(r => r.name).ToList()[recipeNumber - 1];
                                DisplayFullRecipe(selectedRecipe);
                            }
                            else
                            {
                                Console.WriteLine("Invalid recipe number.");
                            }
                        }
                    }
                }



                // this is the method for displaying the full recipe
                private static void DisplayFullRecipe(Recipe recipe)
                {
                    Console.WriteLine("********************************************************************************");

                    Console.WriteLine($"Name of recipe is: {recipe.name}");
                    Console.WriteLine();

                    Console.WriteLine("The Ingredients are as follows:");
                    foreach (var ingredient in recipe.Ingredients)
                    {
                        Console.WriteLine($"{ingredient.quantities} {ingredient.units} of {ingredient.name} ");
                    }

                    Console.WriteLine();

                    Console.WriteLine("The amount of calories for this recipe is:");
                    foreach (var ingredient in recipe.Ingredients)
                    {
                        Console.WriteLine($"{ingredient.calories}  ");

                        sum = ingredient.calories + ingredient.calories;

                        if (sum >= 300)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("The Total amount of calories is " + sum + "The calories you have ented exceeds 300 CALOREIS! ");
                            Console.ResetColor();
                        }

                        else if (sum <= 300)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("The recipe that you have entered does not exceed more than 300 CALORIES ");
                            Console.ResetColor();
                        }




                    }







                    Console.WriteLine();


                    Console.WriteLine("\nThe Food group for this recipe is:");
                    foreach (var ingredient in recipe.Ingredients)
                    {
                        Console.WriteLine($"{ingredient.foodGroup} ");
                    }



                    Console.WriteLine();

                    Console.WriteLine("The Steps :");

                    foreach (var step in recipe.Steps)
                    {
                        Console.WriteLine($" - {step.description}");

                    }
                    Console.WriteLine("********************************************************************************");

                    Console.WriteLine("\nWould you Like to scale your quantities for your recipe\n" +
                        "Press 1 for Yes\n" +
                        "Press 2 for No");
                    int yesOrNo = int.Parse(Console.ReadLine());


                    if (yesOrNo == 1)
                    {


                        Console.Write("\nEnter scaling factor as a number (half 1, double 2, or triple 3): ");
                        int factors = int.Parse(Console.ReadLine());

                 

                        switch (factors)
                        {
                            case 1:
                                recipe.scaleTheRecipe(1);
                                Console.WriteLine("\n");
                                Console.WriteLine("*********** The Updated Recipe: ***********\n");
                                DisplayFullRecipe(recipe);
                                break;

                            case 2:
                                recipe.scaleTheRecipe(2);
                                Console.WriteLine("\n");
                                Console.WriteLine("*********** The Updated Recipe: ***********\n");
                                DisplayFullRecipe(recipe);
                                break;


                            case 3:
                                recipe.scaleTheRecipe(3);
                                Console.WriteLine("\n");
                                Console.WriteLine("*********** The Updated Recipe: ***********\n");
                                DisplayFullRecipe(recipe);
                                break;


                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }

                    }
                    else if (yesOrNo == 2)
                    {
                        Console.WriteLine("Back to Menu");
                    }

                    else
                    {
                        Console.WriteLine("Invaild number");
                    }

                }
                public void ClearTheRecipe()
                {
                    Console.Write("Press 1 to clear the recipe\n" +
                        "Press 2 to cancel\n");
                    int clearData = Convert.ToInt32(Console.ReadLine());

                    if (clearData == 1)
                    {
                        Console.WriteLine("\nAre you sure\n" +
                            "Press 1 for yes\n" +
                            "Press 2 for no");
                        int sure = Convert.ToInt32(Console.ReadLine());

                        if (sure == 1)
                        {
                            recipes.Clear();
                            Console.WriteLine("All data cleared.");

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("The recipe has been cleared\n");
                            Console.ResetColor();
                        }



                        else if (sure == 2)
                        {
                            Console.WriteLine("Canceled back to meun");
                        }

                        else
                        {
                            Console.WriteLine("INVAILD NUMBER");
                        }
                    }


                    else if (clearData == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("The Recipe is still saved back to the menu");
                        Console.ResetColor();
                    }

                    else
                    {
                        Console.Write("Invaild number entered, back to menu\n");
                    }
                }
            }
        }
    }
}








    

