using System;
using System.Threading;
using handgame.Models;

namespace handgame
{
    class Program
    {
        static void Main(string[] args)
        {
                game moves = new game();
                moves.AddChoice(new Choices("rock", "scissors"));
                moves.AddChoice(new Choices("scissors", "paper"));
                moves.AddChoice(new Choices("paper", "rock"));
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
                Console.WriteLine("Hi, I'm buddy! What's Your Name?");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Well Hi " + name + "! Nice to meet you! Do you want to play a game? (y/n)");
                while (deciding){
                    char choice = Console.ReadKey().KeyChar;
                    if(choice == 'n' ){
                        deciding = false;
                        Console.WriteLine("\n");
                        Console.WriteLine("Leaving So Soon. :( Just come Back Quick Okay?");
                    } else if (choice == 'y'){
                        deciding = false;
                        Console.WriteLine("\n");
                        Console.Clear();
                        Console.WriteLine("So glad You want to play with me! Lets Play my favorite game, Hand Attack!");
                        Thread.Sleep(2500);
                        Console.WriteLine("It's a very fun and simple game. Just Choose an Option and I'll let you know if you won! Type help for more info!");
                        Thread.Sleep(3250);
                        Console.WriteLine("You ready? Let's Go!");
                        Console.WriteLine("\n");
                        Console.WriteLine("Moves: ");
                        for (int i = 0; i < moves.Choices.Count; i++){
                            Choices c = moves.Choices[i];
                            Console.WriteLine(c.Name);
                        }
                    } else {
                        Console.WriteLine("\n");
                        Console.WriteLine("That's Not A command Silly, Try Again!");
                    }
            }
        }
    }
}

// To make type | dotnet new console -o 'name of file' |