using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      string playAgain;
      string winOrLose = "tied";

      // As a user, I should see a welcome message.
      Console.WriteLine("Welcome!");

      // Allow the user to play again. hint: while loops
      do
      {

        // Create a way for the user to choose a level of difficulty, normal, impossible, or easy.
        Console.WriteLine("Choose: normal, impossible, or easy");

        //  add some validation around user input.
        var userDifficultyChoice = Console.ReadLine().ToLower();
        while (userDifficultyChoice != "normal" && userDifficultyChoice != "impossible" && userDifficultyChoice != "easy")
        {
          Console.WriteLine("Input invalid!");
          Console.WriteLine("Choose: normal, impossible, or easy");
          userDifficultyChoice = Console.ReadLine().ToLower();
        };



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

        string computerChoice = " ";

        // how to computer answer will differ based on difficulty mode
        // Normal
        if (userDifficultyChoice == "normal")
        {
          // The computer should randomly decide one of the options.
          Random r = new Random();
          string[] choices = {
              "rock",
              "paper",
              "scissor"
            };
          computerChoice = choices[r.Next(choices.Length)];
        }
        // Impossible
        else if (userDifficultyChoice == "impossible")
        {
          if (userChoice == "rock")
          {
            computerChoice = "paper";
          }
          else if (userChoice == "paper")
          {
            computerChoice = "scissor";
          }
          else if (userChoice == "scissor")
          {
            computerChoice = "rock";
          }
        }
        // Easy
        else if (userDifficultyChoice == "easy")
        {
          if (userChoice == "rock")
          {
            computerChoice = "scissor";
          }
          else if (userChoice == "paper")
          {
            computerChoice = "rock";
          }
          else if (userChoice == "scissor")
          {
            computerChoice = "paper";
          }
        }

        // You program should then decide who the winner is;
        if ((computerChoice == "scissor" && userChoice == "rock") || (computerChoice == "rock" && userChoice == "paper") || (computerChoice == "paper" && userChoice == "scissor"))
        {
          winOrLose = "won";
        }
        else if ((computerChoice == "rock" && userChoice == "scissor") || (computerChoice == "paper" && userChoice == "rock") || (computerChoice == "scissor" && userChoice == "paper"))
        {
          winOrLose = "lost";
        }

        // The user should then see the randomly selected option, as well as a win or lose message.
        Console.WriteLine("You've {0}! The computer picked {1}", winOrLose, computerChoice);
        Console.WriteLine("");
        Console.WriteLine("Would you like to play again? ('y' or 'n')");
        playAgain = Console.ReadLine().ToLower();

        // Validation on the choice to play again
        while (playAgain != "y" && playAgain != "n")
        {
          Console.WriteLine("Input invalid!");
          Console.WriteLine("Choose: 'y' or 'n'");
          playAgain = Console.ReadLine().ToLower();
        };

      } while (playAgain == "y");

    }
  }
}
