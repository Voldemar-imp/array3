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
            int linesNumber = 30;
            int[] numbersArray = new int[linesNumber];
            int randomMin = 1;
            int randomMax = 9;
            Random random = new Random();
            int previousNumber = int.MinValue;
            int nextNumber = int.MinValue;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray [i] = random.Next (randomMin, randomMax);
                Console.Write(numbersArray[i]+" ");
            }
            Console.WriteLine("- массив");

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (i != numbersArray.Length - 1)
                {
                    nextNumber = numbersArray[i + 1];
                }
                
                if (i == 0 && numbersArray[i] > nextNumber)
                {
                    Console.Write(numbersArray[i] + " ");
                }
                else if (i == numbersArray.Length - 1 && numbersArray[i] > previousNumber)
                {
                    Console.Write(numbersArray[i] + " ");
                }
                else if (numbersArray[i] > nextNumber && numbersArray[i] > previousNumber)
                {
                    Console.Write(numbersArray[i] + " ");
                }
                else
                {
                    Console.Write("  ");
                }
                previousNumber = numbersArray[i];
            }

            Console.WriteLine("- локальные максимумы массива");
        }
    }
}
