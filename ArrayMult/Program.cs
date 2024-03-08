using System;
using System.Globalization;

namespace ArrayMult
{
    class ArrayMult
    {
        static void Main(string[] args)
        {
            if (args.Length != 6)
            {
                Console.WriteLine("must have 6 arguments");
                return;
            }

            float[,] A = new float[2, 2];
            float[] b = new float[2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    A[i, j] = float.Parse(args[i * 2 + j], CultureInfo.InvariantCulture);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                b[i] = float.Parse(args[4 + i], CultureInfo.InvariantCulture);
            }

            float[] result = new float[2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i] += A[i, j] * b[j];
                }
            }

            // Print the result
            foreach (float value in result)
            {
                Console.WriteLine(value);
            }
        }
    }
}
