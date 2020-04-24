using System;
using System.Collections.Generic;

namespace LV3
{
    class Program
    {
        // Deep copy nije potreban u ovom primjeru jer Dataset nema slozene tipove podatka.

        static void Main(string[] args)
        {
            //zadatak 1
            //Console.WriteLine("Originalni csv: ");
            //Prototype file1 = new Dataset(@"C:\Users\slave\Desktop\zadatak1.csv");
            //FilePrint((Dataset)file1);
            //Console.WriteLine("Deep Copy csv: ");
            //Prototype file2 = file1.Clone();
            //FilePrint((Dataset)file2);

            //zadatak 2
            //MatrixGenerator m = MatrixGenerator.GetInstance();
            //float[][] matrix = m.CreateMatrix(3, 3);
            //FilePrint(matrix);

        }
        static void FilePrint(Dataset d)
        {
            foreach (List<string> listString in d.GetData())
            {
                foreach (string s in listString)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void FilePrint(float[][] f)
        {
            for (int i = 0; i < f.Length; i++)
            {
                for (int j = 0; j < f[i].Length; j++)
                {
                    Console.Write(f[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
