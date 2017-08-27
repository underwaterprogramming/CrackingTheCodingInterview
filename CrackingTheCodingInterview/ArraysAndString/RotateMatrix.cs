using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.ArraysAndString
{
    /*
     * Rotate matrix by 90 degree
     */ 

    public class RotateMatrix
    {

        public static bool Solution1(int[,] matrix)
        {
            if (matrix.Length == 0 || matrix.GetLength(0) != matrix.GetLength(1))
                return false;

            int n = matrix.GetLength(0);
            for(int layer = 0; layer < n/2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for(int i = first; i< last; i++)
                {
                    int offset = i - first;

                    int top = matrix[first, i];

                    // left -> top
                    matrix[first, i] = matrix[last - offset, first];

                    //bottom  -> left
                    matrix[last - offset, first] = matrix[last, last - offset];

                    // right -> bottom
                    matrix[last, last - offset] = matrix[i, last];

                    // top -> right
                    matrix[i, last] = top;
                }
            }
            return true;
        }
    }
}
