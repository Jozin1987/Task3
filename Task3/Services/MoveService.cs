using System;
using System.Collections.Generic;
using System.Text;
using Task3.Model;

namespace Task3.Services
{
    public class MoveService
    {
        public Dictionary<int, Position> GetAvailableMoves(int[][] board, Position current,List<string> signedPositions)
        {
            var result = new Dictionary<int, Position>();
            var gameBoardChecker = new GameBoardCheckerService();
            int moveNumber = 0;
            for (int i = 0; i < 8; i++)
            {
                var newPosition = GetNewPosition(current, i);
                if (signedPositions.Contains($"{newPosition.PositionY}{newPosition.PositionX}"))
                    continue;

                if (gameBoardChecker.CheckCanGo(board, newPosition))
                {
                    result.Add(moveNumber, newPosition);
                    moveNumber++;
                }
            }
            return result;
        }

        public Position GetNewPosition(Position current, int moveNumber)
        {
            var result = new Position();
            switch (moveNumber)
            {
                case 0:
                    result.PositionY = current.PositionY + 2;
                    result.PositionX = current.PositionX - 1;
                    break;
                case 1:
                    result.PositionY = current.PositionY + 2;
                    result.PositionX = current.PositionX + 1;
                    break;
                case 2:
                    result.PositionY = current.PositionY + 1;
                    result.PositionX = current.PositionX - 2;
                    break;
                case 3:
                    result.PositionY = current.PositionY + 1;
                    result.PositionX = current.PositionX + 2;
                    break;
                case 4:
                    result.PositionY = current.PositionY - 1;
                    result.PositionX = current.PositionX - 2;
                    break;
                case 5:
                    result.PositionY = current.PositionY - 1;
                    result.PositionX = current.PositionX + 2;
                    break;
                case 6:
                    result.PositionY = current.PositionY - 2;
                    result.PositionX = current.PositionX - 1;
                    break;
                case 7:
                    result.PositionY = current.PositionY - 2;
                    result.PositionX = current.PositionX + 1;
                    break;
            }
            return result;
        }
    }
}