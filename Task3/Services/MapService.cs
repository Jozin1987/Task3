using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Services
{
    public class MapService
    {
        public int[,] GetMap(int[][] gameBoard)
        {
            return new int[gameBoard.Length, gameBoard[0].Length];
        }
    }
}
