using System;
using Task3.Model;

namespace Task3.Services
{
    public class GameBoardCheckerService
    {
        public bool CheckCanGo(int[][] board, Position position)
        {
            var isCorrect = CheckIsCorrectPosition(board, position);
            if (!isCorrect)
                return isCorrect;

            return CheckPlaceIsFree(board, position);
        }

        public bool CheckIsCorrectPosition(int[][] board, Position position)
        {
            try
            {
                var result = board[position.PositionY][position.PositionX];
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public bool CheckPlaceIsFree(int[][] board, Position position)
        {
            return board[position.PositionY][position.PositionX] == 0;
        }
    }
}
