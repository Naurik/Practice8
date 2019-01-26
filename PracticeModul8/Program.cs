using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModul8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Введите размер массива n X m:");
            int constantaA = int.Parse(Console.ReadLine());
            int constantaB = int.Parse(Console.ReadLine());
            
            Index ind = new Index(constantaA, constantaB);
            for (int i = constantaA; i < constantaB; i++)
            {
                ind[i] = rand.Next(15, 25);
                Console.WriteLine(i + " = " + ind[i]);
            }
            Console.ReadLine();
        }
    }
}
