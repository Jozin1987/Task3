using System.Collections.Generic;
using System.Linq;
using Task3.Model;

namespace Task3.Services
{
    public class FindWayService
    {
        public int GetMinimumNumberOfMoves(int[][] gameBoard)
        {
            var results = GetNumberOfMoves(gameBoard, new Position() { PositionX = 0, PositionY = 0 }, 0, new List<string>());
            return results.Any() ? results.Min() : -1;
        }

        public List<int> GetNumberOfMoves(int[][] gameBoard, Position currentPosition, int moveNumber, List<string> visitedFields)
        {
            var result = new List<int>();
            var moveService = new MoveService();
            var checkPositionService = new CheckPositionService();
            var finalPosition = new Position() { PositionX = gameBoard[0].Length - 1, PositionY = gameBoard.Length - 1 };
            if (checkPositionService.CheckIsFinal(finalPosition, currentPosition))
            {
                result.Add(moveNumber);
                return result;
            }
            var visitedFieldsList = new List<string>(visitedFields);

            visitedFieldsList.Add($"{currentPosition.PositionY}{currentPosition.PositionX}");
            var moves = moveService.GetAvailableMoves(gameBoard, currentPosition, visitedFieldsList);
            if (!moves.Any())
                return null;
            else
            {
                for (int i = 0; i < moves.Count; i++)
                {
                    var resultFindRoad = GetNumberOfMoves(gameBoard, moves[i], moveNumber + 1, visitedFieldsList);
                    if (resultFindRoad == null || !resultFindRoad.Any())
                        continue;
                    else
                    {
                        result.AddRange(resultFindRoad);
                    }
                }
            }

            return result;
        }
    }
}
