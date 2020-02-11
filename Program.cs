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
        Console.WriteLine("Choose: rock, paper, scissor, lizard, or spock");

        //  add some validation around user input.
        var userChoice = Console.ReadLine().ToLower();
        while (userChoice != "rock" && 
               userChoice != "paper" && 
               userChoice != "scissor" &&
               userChoice != "lizard" &&
               userChoice != "spock")
        {
          Console.WriteLine("Input invalid!");
          Console.WriteLine("Choose: rock, paper, scissor, lizard, or spock");
          userChoice = Console.ReadLine().ToLower();
        };

        string computerChoice = "";

        // how the computer answer will differ based on difficulty mode

        // Normal
        if (userDifficultyChoice == "normal")
        {
          // The computer should randomly decide one of the options.
          Random r = new Random();
          string[] choices = {
              "rock",
              "paper",
              "scissor",
              "spock",
              "lizard"
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
          else if (userChoice == "lizard")
          {
            computerChoice = "scissor";
          }
          else if (userChoice == "spock")
          {
            computerChoice = "paper";
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
          else if (userChoice == "lizard")
          {
            computerChoice = "paper";
          }
          else if (userChoice == "spock")
          {
            computerChoice = "rock";
          }
        }

        // Your program should then decide who the winner is;
        if (((computerChoice == "scissor" || computerChoice == "lizard") && userChoice == "rock") || 
            ((computerChoice == "rock" || computerChoice == "spock") && userChoice == "paper") || 
            ((computerChoice == "paper" || computerChoice == "lizard") && userChoice == "scissor")||
            ((computerChoice == "paper" || computerChoice == "spock") && userChoice == "lizard")||
            ((computerChoice == "rock" || computerChoice == "scissor") && userChoice == "spock")){
          winOrLose = "won";
        }
        else if ((computerChoice == "rock" && (userChoice == "scissor" || userChoice == "lizard")) || 
                 (computerChoice == "paper" && (userChoice == "rock" || userChoice == "spock")) || 
                 (computerChoice == "scissor" && (userChoice == "paper" || userChoice == "lizard")) ||
                 (computerChoice == "lizard" && (userChoice == "spock" || userChoice == "paper")) ||
                 (computerChoice == "spock" && (userChoice == "rock" || userChoice == "scissor")))
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
