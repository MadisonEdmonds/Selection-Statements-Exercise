using System;
using System.Diagnostics.Eventing.Reader;

namespace SelectionStatements1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Pick a number between 1 - 1000");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber) 
            {
                Console.WriteLine($"{userInput} is too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }



            Console.WriteLine("What is your favorite subject?");
            
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I hate Math!");
                    break;
                case "science":
                    Console.WriteLine("Science gives me a headache.");
                    break;
                case "english":
                    Console.WriteLine("English is boring.");
                    break;
                case "history":
                    Console.WriteLine("I like History!");
                    break;
                case "physical education":
                case:"PE":
                    Console.WriteLine("Physical education is my favorite class!");
                    break;
                    default:
                    Console.WriteLine("I don't know that subject.");
                    break;
            }
            
        }
    }
}
