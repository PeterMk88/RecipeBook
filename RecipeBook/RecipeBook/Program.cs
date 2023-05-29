using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables and classes
            int menu;
            Cooking cook = new Cooking();

            //menu set up
            Console.WriteLine("***************************");
            Console.WriteLine("Welcome to Recipe Book!");
            Console.WriteLine("***************************");
            Console.WriteLine("1. Add recipe");
            Console.WriteLine("2. Display recipe");
            Console.WriteLine("4. Remove recipe");
            Console.WriteLine("6. Exit");
            Console.WriteLine("***************************");

            //user selects a number
            menu = int.Parse(Console.ReadLine());

            if (menu >= 1 && menu <= 4) { 
            switch (menu)
            {
                case 1:
                    cook.AddRecipe();
                    cook.AddIngredients();
                    cook.AddDescription();
                    cook.CalorieLimit();
                    break;
                case 2:
                    cook.DisplayRecipe();
                    break;
                case 3:
                    cook.Remove();
                    break;
                case 4:
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                    break;
                case 5:
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                    break;
            }
        }
        else {
                //if user doesnt select between 1 and 4
                Console.WriteLine("Invalid choice. Please select within whats given");
                menu = int.Parse(Console.ReadLine());
        }
        }
    }
}
