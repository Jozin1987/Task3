using System;
using System.Collections.Generic;
using Task3.Repository.Repositories;
using Task3.Services;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            IGameBoardRepository gameBoardRepo = new GameBoardRepository();
            var gameBoard = gameBoardRepo.GetGameBoard();
            var roadFinder = new FindWayService();

            Console.WriteLine(roadFinder.GetMinimumNumberOfMoves(gameBoard));
            Console.Read();
        }
    }
}
