using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string argumento in args)
            {
                if (argumento.Length > 6)
                {
                    return;
                }

                if (argumento.Length > 3)
                {
                    Console.WriteLine(argumento);
                }
            }
        }
    }
}
