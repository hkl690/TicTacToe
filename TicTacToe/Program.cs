using TicTacToe.Classes;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            HumanPlayer player1 = new HumanPlayer();
            ComputerPlayer computer = new ComputerPlayer();
            string HumanSymbol = "X"; // Human player uses "X"
            string ComputerSymbol = "O"; // Computer uses "O"

            bool IsHumanTurn = true; // Start with human player

            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            while (true) // main game loop
            {
                board.Display();
                if (IsHumanTurn)
                {
                    Console.WriteLine("Your turn:");
                    int[] move = player1.GetMove(board);
                    board.MakeMove(move[0], move[1], HumanSymbol);
                    IsHumanTurn = false; // Switch to computer player
                }
                else
                {
                    Console.WriteLine("Computer's turn:");
                    int[] move = computer.GetMove(board);
                    board.MakeMove(move[0], move[1], ComputerSymbol);
                    IsHumanTurn = true; // Switch to human player
                }

                // Break condition (e.g., win/tie) to be added
            }

        }
    }
}