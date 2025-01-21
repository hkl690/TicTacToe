using System;


namespace TicTacToe.Classes
{
    public class Board
    {
        private readonly string[,] grid; // 2D array to represent the board
        private readonly List<int[]> MovesPlayed; // List to store all moves played

        // Constructor to initialize the board
        public Board()
        {
            grid = new string[3, 3]; // Create a 3 x 3 board
            MovesPlayed = new List<int[]>(); // Initialize the list of moves
        }


        /// <summary>
        /// Method to display the current state of the board
        /// </summary>
        public void Display()
        {
            Console.WriteLine("0   1   2"); // Print column numbers
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(string.IsNullOrEmpty(grid[row, col]) ? "." : grid[row, col]); // Print each cell
                    if (col < 2) Console.Write(" | "); // Column separator
                }
                Console.WriteLine(); // Move to the next row

                if (row < 2) Console.WriteLine("--+---+--"); // Row separator
            }
        }
        /// <summary>
        /// Checks if the specified move is valid.
        /// </summary>  
        /// <param name=="row">Row index of the move.</param>
        /// </param name=="col">Column index of the move.</param>
        /// <returns>True if the move is valid, false otherwise.</returns>
        public bool IsValidMove(int row, int col)
        {
            // Check if within bounds
            if (row < 0 || row >= 3 || col < 0 || col >= 3)
            { return false; }

            // Check if the space is already occupied
            if (!string.IsNullOrEmpty(grid[row, col]))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Places a player's symbol on the board.
        /// </summary>  
        /// <param name="row">Row index of the move.</param>
        /// <param name="col">Column index of the move.</param>
        /// <param name="symbol">The player's symbol ('X' or 'O').</param>
        public void MakeMove(int row, int col, string PlayerSymbol)
        {
            grid[row, col] = PlayerSymbol;
            MovesPlayed.Add(new int[] { row, col }); // Add the move to the list
        }

        /// <summary>
        /// Checks if there is a winner on the board
        /// </summary>  
        /// <returns>The winning symbol ("X" or "O") if a winner exists, null otherwise.</returns>
        public string CheckWinner()
        {
            //Check rows and columns for a winner
            for (int row = 0; row < 3; row++)
            {
                // Check rows
                if (!string.IsNullOrEmpty(grid[row, 0]) && grid[row, 0] == grid[row, 1] && grid[row, 1] == grid[row, 2])
                {
                    return grid[row, 0];
                }
                // Check columns
                if (!string.IsNullOrEmpty(grid[0, row]) && grid[0, row] == grid[1, row] && grid[1, row] == grid[2, row])
                {
                    return grid[0, row];
                }
            }

            // Check diagonals for a winner
            if (!string.IsNullOrEmpty(grid[0, 0]) && grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2])
            {
                return grid[0, 0];
            }
            if (!string.IsNullOrEmpty(grid[0, 2]) && grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0])
            {
                return grid[0, 2];
            }
            // No winner found
            return null;
        }

        /// <summary>
        /// Checks if the board is full, resulting in a tie
        /// </summary>
        /// <returns>True if the board is full, false otherwise.</returns>
        public bool IsTie()
        {
            foreach (var cell in grid)
            {
                if (string.IsNullOrEmpty(cell))
                {
                    return false; // If any cell is empty, the game is not a tie
                }
            }
            return true; // All cells are filled, the game is a tie
        }
    }
}