using System;

namespace password_gen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                for (; ; )
                {
                    Console.WriteLine("How long password do you want to create?\nPut symbols QTY.");
                    int n = int.Parse(Console.ReadLine());
                    Random rnd = new Random();
                    int size = n, k;
                    char[] symbs = new char[size];
                    Console.WriteLine("Password:");
                    for (k = 0; k < symbs.Length; k++)
                    {
                        symbs[k] = (char)('!' + rnd.Next(97));
                        Console.Write(symbs[k]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("---");
                }
            }
        }
    }
}
