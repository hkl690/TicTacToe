using System;
using TicTacToe.Classes;


namespace TicTacToe.Interfaces
{
    /// <summary>
    /// Interface for humans and computers that play the game.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Method to get the input from the player
        /// </summary>
        /// <returns>the move that was played</returns>
        int[] GetMove(Board board); 
    }
}
