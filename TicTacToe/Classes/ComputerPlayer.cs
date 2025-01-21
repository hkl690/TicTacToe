using System;
using TicTacToe.Interfaces;

namespace TicTacToe.Classes
{
    /// <summary>
    /// Represents a computer player in the game.
    /// </summary>
    internal class ComputerPlayer : IPlayer
    {
        private readonly Random random = new Random();

        /// <inheritdoc/>
        public int[] GetMove(Board board)
        {
            int row = 0;
            int col = 0;
            bool ValidMove = false;

            // Loop until the computer makes a valid move
            while (!ValidMove)
            {
                // Generate a random move (row and column between 0 and 2)
                row = random.Next(0, 3);
                col = random.Next(0, 3);

                // Check if the move is valid by calling IsValidMove on the board
                if (board.IsValidMove(row, col))
                {
                    ValidMove = true; // The move is valid, exit the loop
                }
                else
                {
                    // The move is invalid, try again
                    Console.WriteLine("Invalid move. Trying again...");
                }
            }

            // After a valid move is found, return the move
            Console.WriteLine($"Computer chooses: {row} {col}");
            return new int[] { row, col };
        }

    }
}
