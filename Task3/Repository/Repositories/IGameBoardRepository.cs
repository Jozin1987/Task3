using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Repository.Repositories
{
    public interface IGameBoardRepository
    {
        int[][] GetGameBoard();
    }
}
