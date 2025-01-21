using System;


namespace TicTacToe
{
    public class Board
    {
        private char[,] grid; // 2D array to represent the board

        // Constructor to initialize the board
        public Board()
        {
            grid = new char[3, 3]; // Create a 3 x 3 board
            InitializeBoard(); // Fill it with empty spaces
        }

        // Method to initialize the board with empty spaces
        private void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    grid[row, col] = ' '; // Set each cell to a space
                }
            }
        }

        // Method to print the board
        public void Display()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(grid[row, col]); // Print each cell
                    if (col < 2) Console.Write(" | "); // Add vertical dividers
                }
                Console.WriteLine(); // Move to the next row

                if (row < 2) Console.WriteLine("--+---+--"); // Add horizontal dividers
            }
        }

    }
}
