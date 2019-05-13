using System;
using System.Collections.Generic;
using System.Text;
using Task3.Model;

namespace Task3.Services
{
    public class CheckPositionService
    {
        public bool CheckIsFinal(Position finalPosition, Position currentPosition)
        {
            return currentPosition.PositionX == finalPosition.PositionX && currentPosition.PositionY == finalPosition.PositionY;
        }
    }
}
