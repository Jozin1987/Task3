using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Repository.Repositories
{
    public class GameBoardRepository : IGameBoardRepository
    {
        public int[][] GetGameBoard()
        {
            var row1 = new int[] { 0, 0, 0 };
            var row2 = new int[] { 0, 0, 1 };
            var row3 = new int[] { 1, 0, 0 };
            var row4 = new int[] { 0, 0, 0 };
            return new int[][] { row1, row2, row3, row4 };
        }
    }
}
