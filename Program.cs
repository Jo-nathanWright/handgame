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
      bool playing = true;
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
      while (deciding)
      {
        char choice = Console.ReadKey().KeyChar;
        if (choice == 'n')
        {
          deciding = false;
          Console.WriteLine("\n");
          Console.WriteLine("Leaving So Soon. :( Just come Back Quick Okay?");
        }
        else if (choice == 'y')
        {
          deciding = false;
          Console.WriteLine("\n");
          Console.Clear();
          Console.WriteLine("So glad You want to play with me! Lets Play my favorite game, Hand Attack!");
          Thread.Sleep(2500);
          Console.WriteLine("It's a very fun and simple game. Just Choose an Option and I'll let you know if you won! Type help for more info!");
          Thread.Sleep(3250);
          Console.WriteLine("You ready? Let's Go!");
          Console.WriteLine("\n");
          while (playing)
          {
            Console.Clear();
            Console.WriteLine("Moves: ");
            for (int i = 0; i < moves.Choices.Count; i++)
            {
              Choices c = moves.Choices[i];
              Console.WriteLine("  -" + c.Name);
            }
            Console.Write("Your Move: ");
            string didMove = Console.ReadLine().ToLower();
            Choices pChoice = moves.Choices.Find(c => c.Name.ToLower() == didMove);
            if (pChoice == null)
            {
              Console.WriteLine("Thats Not A Move Silly. Choose a Real Move!");
              Thread.Sleep(2500);
            }
            else if (pChoice.Name == "rock")
            {
              Console.WriteLine("You Choose Rock!");
              Thread.Sleep(2500);
            }
            else if (pChoice.Name == "scissors")
            {
              Console.WriteLine("You Choose Scissors!");
              Thread.Sleep(2500);
            }
            else if (pChoice.Name == "paper")
            {
              Console.WriteLine("You Choose Paper!");
              Thread.Sleep(2500);
            }
            Console.WriteLine("Want to play Again? (y/n)");
            char playAgain = Console.ReadKey().KeyChar;
            if (playAgain == 'n')
            {
              playing = false;
              Console.WriteLine("\n");
              Console.WriteLine("At least we played A little. See you next time " + name + "!");
            }
            else{
              Console.WriteLine("Great, lets go again!");
            }
          }
        }
        else
        {
          Console.WriteLine("\n");
          Console.WriteLine("That's Not A command Silly, Try Again!");
        }
      }
    }
  }
}

// To make type | dotnet new console -o 'name of file' |