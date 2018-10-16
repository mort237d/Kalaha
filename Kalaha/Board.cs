using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalaha
{
    class Board
    {
        private int[,] boardIntArray = new int[3, 8];
        private string[,] boardStringArray = new string[3, 8];
        private int startPoint = 3;
        public Board()
        {
            InsertBoardAndValuesToArray();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(boardStringArray[i, j]);
                }
                Console.WriteLine();
            }
        }

        private void InsertBoardAndValuesToArray()
        {
            for (int i = 0; i < 3; i = i + 2)
            {
                for (int j = 1; j < 7; j++)
                {
                    boardIntArray[i, j] = startPoint;
                    boardStringArray[i, j] = "(" + boardIntArray[i, j] + ")";
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (boardStringArray[i, j] != "(" + boardIntArray[i, j] + ")")
                    {
                        boardStringArray[i, j] = "   ";
                    }
                }
            }

            boardIntArray[1, 0] = startPoint;
            boardIntArray[1, 7] = startPoint;
            boardStringArray[1, 0] = "(" + boardIntArray[1, 0] + ")";
            boardStringArray[1, 7] = "(" + boardIntArray[1, 7] + ")";
        }
    }
}
