using System;
using System.IO;

namespace Lab10
{
    class Program
    {
        class Matrix
        {
            public float[,] matrix;
            int m, n;

            public Matrix() { }

            public void GenerateMatrix(int M, int N)
            {
                m = M; n = N;

                Random r = new Random(DateTime.Now.Millisecond);

                matrix = new float[M, N];

                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        matrix[i, j] = (float)r.Next(1000) / 973f;
                    }
                }
            }

            public void SaveMatrix(string pFileName)
            {
                if (matrix.Length > 0)
                {
                    if (File.Exists(pFileName))
                        File.Delete(pFileName);

                    FileInfo f = new FileInfo(pFileName);
                    TextWriter tw = f.CreateText();

                    tw.WriteLine(m.ToString());
                    tw.WriteLine(n.ToString());

                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            tw.WriteLine(i.ToString() + " " + j.ToString() + " " + matrix[i, j].ToString("E10"));
                        }
                    }
                    tw.Close();
                }

            }

            public bool LoadMatrix(string pFileName)
            {
                if (File.Exists(pFileName))
                {
                    try
                    {
                        TextReader tr = File.OpenText(pFileName);
                        m = Convert.ToInt32(tr.ReadLine());
                        n = Convert.ToInt32(tr.ReadLine());

                        matrix = new float[m, n];
                        string line;
                        string[] substring;

                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                line = tr.ReadLine();
                                substring = line.Split(new char[] { ' ' }, 3);
                                matrix[i, j] = Convert.ToSingle(substring[2]);
                            }
                        }
                        tr.Close();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                return false;
            }

            public void PrintMatrix()
            {
                Console.WriteLine("*******   Матрица   *******");
                if (matrix.Length > 0)
                {
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(matrix[i, j].ToString("E3") + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

        public static class MatrixOperations
        {
            private static float Sum1Lines(float[,] matrix)
            {
                float sum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (i % 2 == 0)
                        {
                            sum += matrix[i, j];
                        }
                    }
                }

                return sum;
            }

            public static void Sum2Lines(float[,] matrix, float[,] matrix2)
            {
                Console.WriteLine($"Сумма чётных строк {Sum1Lines(matrix) + Sum1Lines(matrix2)}");
            }
        }
        static void Main(string[] args)
        {
            Matrix m = new Matrix();
            m.GenerateMatrix(5, 2);
            m.SaveMatrix("MatrixFile.txt");

            Matrix m2 = new Matrix();
            m2.GenerateMatrix(2, 2);
            m2.SaveMatrix("MatrixFile2.txt");

            if (m.LoadMatrix("MatrixFile.txt")) 
                m.PrintMatrix();
            
            if (m2.LoadMatrix("MatrixFile2.txt"))
                m2.PrintMatrix();

            MatrixOperations.Sum2Lines(m.matrix, m2.matrix);

            Console.ReadKey();
        }
    }
}
