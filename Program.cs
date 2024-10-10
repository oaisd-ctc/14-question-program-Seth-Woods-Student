using System;

public class Program
{
        static void Main(string[] args)
        {
                Console.WriteLine("Hello! What is your name?");
                string name = Console.ReadLine();

                Console.WriteLine("what is your age?");
                int ageNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("what is your eye color?");
                string eyecolor = Console.ReadLine();

                Console.WriteLine("what is your hair color?");
                string haircolor = Console.ReadLine();

                Console.WriteLine("what is your shoe size?");
                string shoesize = Console.ReadLine();

                Console.WriteLine("what is your favorite color?");
                string color = Console.ReadLine();

                Console.WriteLine("What is your favorite movie?");
                string movie = Console.ReadLine();

                Console.WriteLine("what is your favorite teacher?");
                string teacher = Console.ReadLine();

                Console.WriteLine("what is your favorite class?");
                string favoriteClass = Console.ReadLine();

                    Console.WriteLine("what is your favorite holiday?");
            string holiday = Console.ReadLine();

        Console.WriteLine("what is your favorite season?");
            string season = Console.ReadLine();

        Console.WriteLine("what is your dream job?");
            string job = Console.ReadLine();

        Console.WriteLine("how many siblings do you have?");
            string sibling = Console.ReadLine();
        Console.WriteLine("hello " + name + ". you have " + eyecolor + "eyes, " + haircolor + " hair, and your shoe size is a "
         + shoesize + ". your favorite color is " + color + ", favorite movie " + movie + ", favorite teacher " + teacher 
         + ", favorite class " + favoriteClass + ", favorite holiday " + holiday + ", favorite season " + season 
         + ", and your dream job is " + job + ". You have " + sibling + "sibling" + ", and you will be " + (ageNumber + 5) + " in five years.");

}
    
   }

