/*
Luke Rowberry
Chapter 2 Examples
9-21-2021
GameDev #1
*/

//Tested by Spencer Burton, looks good to me 9/10, I think you have 21 questions but it's difficult to count

//Imports Zone
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bulk Code Zone
namespace Chapter_2_YAHOO_SHWING
{

    //Required within namespace to work
    class Program
    {
        //Required to make class work
        static void Main(string[] args)
        {
            Console.Write("First Name: ");
            String fname = Console.ReadLine();
            
            Console.Write("Last Name: ");
            String lname = Console.ReadLine();

            Console.Write("Toaster Brand: ");
            String toaster = Console.ReadLine();

            Console.Write("Favorite Pizza Topping: ");
            String topping  = Console.ReadLine();

            Console.Write("Favorite Cat Breed: ");
            String cat = Console.ReadLine();

            Console.Write("Favorite Anime Character: ");
            String anime = Console.ReadLine();            

            Console.Write("Favorite Ice Cream: ");
            String cream = Console.ReadLine();            

            Console.Write("Do You Like Pinapple On Pizza?: ");
            String pineapple = Console.ReadLine();            

            Console.Write("Do you have sticky keys enabled?: ");
            String sticky = Console.ReadLine();            

            Console.Write("What is your milk type?: ");
            String milk = Console.ReadLine();           

            Console.Write("Is Beyonce still a single lady?: ");
            String beyonce = Console.ReadLine();
            
            Console.Write("Can Get Cheese?: ");
            String cheese  = Console.ReadLine();            

            Console.Write("Do you like waffles?: ");
            String waffle = Console.ReadLine();           

            Console.Write("Is there a leak in your house?: ");
            String leak = Console.ReadLine();           

            Console.Write("How do you cook your steak?: ");
            String steak = Console.ReadLine();           

            Console.Write("Do you prefer pie or cake?: ");
            String cake_pie = Console.ReadLine();            

            Console.Write("Zodiac Sign: ");
            String zodiac = Console.ReadLine();            

            Console.Write("What does your Pluto mean?: ");
            String planet = Console.ReadLine();            

            Console.Write("Are you the favorite child?: ");
            String child = Console.ReadLine();            

            Console.Write("Are you lonely?: ");
            String lonely = Console.ReadLine();            

            Console.Write("Do you know Jake from StateFarm?: ");
            int jake = Console.ReadLine();

            Console.WriteLine("Results: ");
            Console.WriteLine(fname);
            Console.WriteLine(lname);
            Console.WriteLine(toaster);
            Console.WriteLine(topping);
            Console.WriteLine(cat);
            Console.WriteLine(anime);
            Console.WriteLine(cream);
            Console.WriteLine(pineapple);
            Console.WriteLine(sticky);
            Console.WriteLine(milk);
            Console.WriteLine(beyonce);
            Console.WriteLine(cheese);
            Console.WriteLine(waffle);
            Console.WriteLine(leak);
            Console.WriteLine(steak);
            Console.WriteLine(cake_pie);
            Console.WriteLine(zodiac);
            Console.WriteLine(planet);
            Console.WriteLine(child);
            Console.WriteLine(lonely);
            Console.WriteLine(jake);
            Console.ReadLine();
        }//Ends Main Method
    }//Ends Class Program
}//Ends Namespace
