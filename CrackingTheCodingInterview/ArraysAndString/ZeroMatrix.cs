using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.ArraysAndString
{
    /*
     * Write an algorithm such that if an element in an M*N matrix is 0,
     * its entire row and column are set to 0.
     */
    public class ZeroMatrix
    {
        public static void Solution1(int[,] matrix)
        {
            // first find out which row and which column has 0 and add them to respective variable
            int rowsWithZero = 0;
            int columnsWithZero = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        if ((rowsWithZero & 1 << i) == 0)
                            rowsWithZero |= 1 << i;
                        if ((columnsWithZero & 1 << j) == 0)
                            columnsWithZero |= 1 << j;
                    }
                }
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int row = rowsWithZero & 1;
                int column = columnsWithZero & 1;

                rowsWithZero = rowsWithZero >> 1;
                columnsWithZero = columnsWithZero >> 1;

                if (row == 1)
                    NullifyRows(matrix, i);
                if (column == 1)
                    NullifyColumns(matrix, i);
            }


        }

        public static void NullifyColumns(int[,] matrix, int column)
        {
            for (int r = 0; r < matrix.GetLength(1); r++)
            {
                if (matrix[r, column] != 0)
                    matrix[r, column] = 0;
            }
        }

        public static void NullifyRows(int[,] matrix, int row)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                if (matrix[row, c] != 0)
                    matrix[row, c] = 0;
            }
        }
    }
}
