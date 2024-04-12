// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Recipe recipe = new Recipe();
        while (true)+
            
        {
            
            Console.WriteLine("=========================================");
            Console.WriteLine("Press 1 to Enter your recipe details");
            Console.WriteLine("Press 2 to Display the recipe");
            Console.WriteLine("Press 3 to Scale the recipe");
            Console.WriteLine("Press 4 to Reset your quantities");
            Console.WriteLine("Press 5 to Clear your recipe");
            Console.WriteLine("Press 6 to Exit your recipe");
            Console.WriteLine("========================================="); 

            
            string ans= Console.ReadLine();
            switch(ans)
            {
                case "1":
                    recipe.EnterData();
                    break;
                case "2":
                    recipe.RecipeDisplay();
                    break;
                case "3":
                    Console.WriteLine("Enter a scale of 0.5, 2 or 3");
                    double scale1=Convert.ToDouble(Console.ReadLine());
                    recipe.RecipeScale(scale1);
                    break;
                 case "4":
                    recipe.ResetRecipe();
                    break;
                 case "5":
                    recipe.ClearRecipe();
                    break;
                 case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong value. Please try again");
                    break;

        }
    }
    }
    }
    
    class Recipe
        
    {
        
        // Declare ingredients
        // Declare quantity
        // Declare unit
        // Declare steps
        private string[] ingredients;
        private double[] quantity;
        private string[] unit;
        private string[] steps;
        public Recipe()
            
        {
            
            ingredients = new string[0];
            quantity = new double[0];
            unit = new string[0];
            steps = new string[0];
        }

        // user enters details
        public void EnterData()
            
        {

            Console.WriteLine("Enter your recipe details");

            //enter ingredients
            Console.WriteLine("Enter the number of ingredients");


            int ingredientsNo = Convert.ToInt32(Console.ReadLine());

            ingredients = new string[ingredientsNo];
            quantity = new double[ingredientsNo];
            unit = new string[ingredientsNo];

            for (int i = 0; i < ingredientsNo; i++)
                
            {
                
            Console.WriteLine($"Ingredient details {1 + 1}:");
                Console.Write("Name:");
                ingredients[i] = Console.ReadLine();

                Console.Write("Quantity: ");
                quantity[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Measuremnet unit: ");
                unit[i] = Console.ReadLine();
            }

            Console.WriteLine(" Enter number of Steps: ");
            int stpNo = Convert.ToInt32(Console.ReadLine());
            steps = new string[stpNo];
            for (int a = 0; a < stpNo; a++)
                
            {
                
                Console.Write($"Steps{ a+1}:");
                steps[a] = Console.ReadLine();
            
        }
        }

        //This makes the whole recipe to display
        public void RecipeDisplay()
            
        {
            
            Console.WriteLine("\nHere is your recipe:");
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"-{quantity[i]}{unit[0]} of {ingredients[i]}");
            }
            Console.WriteLine("\nSteps:");
            for (int a = 0; a < steps.Length; a++)
            {
                Console.WriteLine($"{a + 1} . {steps[a]}");
            }
        }
        
        //Quantity of all your ingredients
        public void RecipeScale(double scale)
        {
            for (int i = 0; i<quantity.Length; i++)
            {
                quantity[i] *= scale;
            }
        }
        
        //This resets your recipe for you to be able to start again
        public void ResetRecipe()
            
        {
            
            for(int i = 0;i<quantity.Length;i++)
            {
                quantity[i] /= 2;
            }
        }

        //This enables you to clear your recipe 
        public void ClearRecipe()
        {
            ingredients = new string[0];
            quantity = new double[0];
            unit = new string[0];
            steps=new string[0];
        }
    }













