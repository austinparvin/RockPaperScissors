using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      string computerChoice;
      string winOrLose = "tied";

      //  As a user, I should see a welcome message.
      Console.WriteLine("Welcome!");
      //  As a user, I should see the options I can pick (i.e., "rock", "paper", "scissor")
      Console.WriteLine("Choose: rock, paper, or scissor");

      //  add some validation around user input.
      var userChoice = Console.ReadLine().ToLower();

      //check to see if the user entered anything other than the answer choices
      // if so prompt them to re-enter
      // do this while user choice is not equal to a valid options




      while (userChoice != "rock" && userChoice != "paper" && userChoice != "scissor")
      {
        Console.WriteLine("Input invalid!");
        Console.WriteLine("Choose: rock, paper, or scissor");
        userChoice = Console.ReadLine().ToLower();
      };

      //  The computer should randomly decide one of the options.
      Random r = new Random();
      var computerNumber = r.Next(0, 2);

      if (computerNumber == 0)
      {
        computerChoice = "rock";
      }
      else if (computerNumber == 1)
      {
        computerChoice = "paper";
      }
      else
      {
        computerChoice = "scissor";
      }

      //  You program should then decide who the winner is;
      if ((computerChoice == "rock" && userChoice == "paper") || (computerChoice == "paper" && userChoice == "scissor") || (computerChoice == "scissor" && userChoice == "paper"))
      {
        winOrLose = "won";
      }
      else if ((computerChoice == "rock" && userChoice == "scissor") || (computerChoice == "paper" && userChoice == "rock") || (computerChoice == "scissor" && userChoice == "rock"))
      {
        winOrLose = "lost";
      }

      //  The user should then see the randomly selected option, as well as a win or lose message.
      Console.WriteLine("You've {0}! The computer picked {1}", winOrLose, computerChoice);



    }
  }
}
