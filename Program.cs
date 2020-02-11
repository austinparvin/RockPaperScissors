using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      string winOrLose = "tied";

      //  As a user, I should see a welcome message.
      Console.WriteLine("Welcome!");
      //  As a user, I should see the options I can pick (i.e., "rock", "paper", "scissor")
      Console.WriteLine("Choose: rock, paper, or scissor");

      //  add some validation around user input.
      var userChoice = Console.ReadLine().ToLower();
      while (userChoice != "rock" && userChoice != "paper" && userChoice != "scissor")
      {
        Console.WriteLine("Input invalid!");
        Console.WriteLine("Choose: rock, paper, or scissor");
        userChoice = Console.ReadLine().ToLower();
      };

      //  The computer should randomly decide one of the options.
      Random r = new Random();
      string[] choices = {
        "rock",
        "paper",
        "scissor"
      };
      var computerChoice = choices[r.Next(choices.Length)];

      //  You program should then decide who the winner is;
      if ((computerChoice == "scissor" && userChoice == "rock") || (computerChoice == "rock" && userChoice == "paper") || (computerChoice == "paper" && userChoice == "scissor"))
      {
        winOrLose = "won";
      }
      else if ((computerChoice == "rock" && userChoice == "scissor") || (computerChoice == "paper" && userChoice == "rock") || (computerChoice == "scissor" && userChoice == "paper"))
      {
        winOrLose = "lost";
      }

      //  The user should then see the randomly selected option, as well as a win or lose message.
      Console.WriteLine("You've {0}! The computer picked {1}", winOrLose, computerChoice);
    }
  }
}
