using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySise = 30;
            int[] numbersArray = new int[arraySise];
            int randomMin = 1;
            int randomMax = 9;
            Random random = new Random();
            int previousNumber = int.MinValue;
            int nextNumber = int.MinValue;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = random.Next(randomMin, randomMax);
                Console.Write(numbersArray[i] + " ");
            }

            Console.WriteLine("- массив");

            if (numbersArray[0] > numbersArray[1])
            {
                Console.Write(numbersArray[0] + " ");
            }                     
            else
            {
                Console.Write("  ");
            }

            for (int i = 1; i < numbersArray.Length-1; i++)
            {                 
                if (numbersArray[i] > numbersArray[i+1] && numbersArray[i] > numbersArray[i - 1])
                {
                    Console.Write(numbersArray[i] + " ");
                }
                else
                {
                    Console.Write("  ");
                }
            }

            if (numbersArray[arraySise-1] > numbersArray[arraySise - 2])
            {
                Console.Write(numbersArray[arraySise - 1] + " ");
            }            
            else
            {
                Console.Write("  ");
            }

            Console.WriteLine("- локальные максимумы массива");
        }
    }
}
