using System;
using System.Threading;

namespace handgame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool deciding = true;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("Initializing Buddy!");
                Thread.Sleep(2000);
                Console.WriteLine("Loading your new best friend!");
                Thread.Sleep(2000);
                Console.WriteLine("...");
                Thread.Sleep(5000);
                Console.Clear();
            while (deciding){
                Console.WriteLine("Hi, I'm buddy! What's Your Name?");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Well Hi " + name + "! Nice to meet you! Do you want to play a game? (y/n)");
                char choice = Console.ReadKey().KeyChar;
                if(choice == 'n'){
                    deciding = false;
                    Console.WriteLine("Leaving So Soon. :( Just come Back Quick Okay?");
                } else if (choice == 'y'){
                    deciding = false;
                    Console.WriteLine("So glad You want to play with me! Lets Play my favorite game, Hand Attack!");
                } else {
                    Console.WriteLine("That's Not A command Silly, Try Again!");
                }
            }
        }
    }
}

// To make type | dotnet new console -o 'name of file' |