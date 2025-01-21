using TicTacToe.Interfaces;
using System.Linq;
using TicTacToe.Interfaces;
using System.Data;

namespace TicTacToe.Classes
{
    /// <summary>
    /// Represents a human player in the game.
    /// </summary>
    public class HumanPlayer : IPlayer
    {
        /// <inheritdoc />
        public int[] GetMove(Board board)
        {
            int row, col;
            while (true) // Keep asking until valid input is provided
            {
                Console.WriteLine("Please input the row and column of your move (e.g. 1 2):");
                string UserInput = Console.ReadLine();

                string[] InputParts = UserInput.Split(' ');

                // Validate input: must have exactly two parts and both must be numbers
                if (InputParts.Length == 2 && int.TryParse(InputParts[0], out row) &&
                    int.TryParse(InputParts[1], out col) && board.IsValidMove(row, col))
                {
                    break; // Valid move
                }
                else
                {
                    Console.WriteLine("Invalid format. Please enter your move as two numbers separated by a space.");
                }
            }
            return new int[] { row, col }; // Return the valid input
        }
}
}
