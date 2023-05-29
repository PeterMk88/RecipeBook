using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook
{
    internal class Cooking
    {
        //variables and generic lists
        Program prog = new Program();
        public List<Cooking> Cookings = new List<Cooking>();
        List<string> recipes = new List<string>();
        List<int> steps = new List<int>();
        List<int> quantitys = new List<int>();
        List<string> ingred = new List<string>();
        List<int> numIng = new List<int>();
        List<string> units = new List<string>();
        List<string> foodGroup = new List<string>();
        List<int> calories = new List<int>(); 
        List<string> Descrip = new List<string>();
        bool addingIng;
        int totalCalories, step, numIngredients;
        string choice, rem;

        public void AddRecipe()
        {
            //adding recipe to the list and variables
            Console.WriteLine("What is the name of the recpie?");
            recipes.Add(Console.ReadLine());
        }

        public void AddIngredients()
        {
            Console.WriteLine("Do you want to insert an ingredient? yes/no");
            choice = Console.ReadLine();
            if (choice == "yes") 
            {
                addingIng = true;
            }
            else if (choice == "no")
            {
                addingIng= false;
            }
            else
            {
                Console.WriteLine("incorrect input. Type in yes or no");
            }

            while (addingIng == true)
            {
                Console.WriteLine("What is the name of the ingredient");
                ingred.Add(Console.ReadLine());
                Console.WriteLine("The amount of the ingredient");
                quantitys.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("The units used eg. ml");
                units.Add(Console.ReadLine());
                Console.WriteLine("What food group is it in?");
                foodGroup.Add(Console.ReadLine());
                Console.WriteLine("how many calories does it have?");
                calories.Add(int.Parse(Console.ReadLine()));
            }
        }

        public void AddDescription()
        {
            //adding steps, no of steps and descriptions
            Console.WriteLine("How many steps are we adding?");
            step = int.Parse(Console.ReadLine());
            steps.Add(step);
            string description;
            for (int i = 0; i < step; i++)
            {
                Console.WriteLine("Please add the description for step number " + step[i]);
                description = Console.ReadLine();
                Descrip.Add(description);
            }
        }

        public void TotalCalorie() 
        { 
            int totalCalories = 0;
            for (int i = 0; i < calories.Count; i++)
            {
                totalCalories = totalCalories + calories[i];
            }
        }

        public void CalorieLimit() 
         {
             //determines if calories in total are above 300 or not
             if (totalCalories > 300)
             {
                 Console.WriteLine("the total calorie amount exceeds 300");
             }
         }

        public void DisplayRecipe()
        {
            //method to display data
            Console.WriteLine("The recipe name is: " + recipes);
            Console.WriteLine("The number of ingredients are: " + numIngredients);
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Ingredient: " + ingred[i] + "with the amount of " + quantitys);
            }
            Console.WriteLine("The steps are:");
            for (int i = 0; i < step; i++)
            {
                Console.WriteLine("Step " + steps);
                Console.WriteLine(Descrip[i]);
            }
        }

        public void AlphabeticalOrder()
        {
            //sorting recipes in alphabetical order
            foreach (Ingredients ingredients in ingred.OrderBy(ingred=>ingred))
            {
                Console.WriteLine("Recipe Name: " + recipes);
                Console.WriteLine("Ingredients: " + ingred);
                Console.WriteLine("Quantity: " + quantitys);
                Console.WriteLine("Units: " + units);
                Console.WriteLine("Food group: " + foodGroup);
                Console.WriteLine("Calories: " + totalCalories);
            }
        }

        public void Remove()
        {
            //method to remove recipe
            Console.WriteLine("Which recipe do you want to remove");
            rem = Console.ReadLine();
            ingred.Remove(rem);
            Console.WriteLine("It has been deleted");
        }
    }
}
