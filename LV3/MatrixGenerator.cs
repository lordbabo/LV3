using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class MatrixGenerator
    {
        public static MatrixGenerator instance;
        private Random random;

        private MatrixGenerator()
        {
            random = new Random();
        }

        public static MatrixGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }

        public float[][] CreateMatrix(int height, int width)
        {
            float[][] matrix = new float[height][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new float[width];
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i][j] = (float)random.NextDouble();
                }
            }

            return matrix;
        }
    }
}
