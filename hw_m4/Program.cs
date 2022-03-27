using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_m4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Input checked task: ");
            int choose = int.Parse(Console.ReadLine());

            
            if (choose == 1)
            {
                // Task #1
                int str, col, sum = 0;

                Console.Write("Input number of string: ");
                str = int.Parse(Console.ReadLine());
                Console.Write("Input number of coloumn: ");
                col = int.Parse(Console.ReadLine());

                int[,] matrix = new int[str, col];

                Random r = new Random();

                for (int i = 0; i < str; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        matrix[i, j] = r.Next(10);
                        Console.Write($"{matrix[i, j]}  ");
                        sum += matrix[i, j];
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"All elements summary: {sum}");

            } 
            else if (choose == 2)
            {
                //Task #2
                Console.Write("Input sequence length: ");
                int len = int.Parse(Console.ReadLine());

                int [] sequence = new int[len];

                Console.WriteLine("Input every number of sequence: ");
                for (int i = 0; i < len; i++)
                {
                    Console.Write($"{i+1}: ");
                    sequence[i] = int.Parse(Console.ReadLine());
                }

                //First example
                int min = sequence[0];
                for (int i = 0; i < sequence.Length; i++)
                {
                    if (min > sequence[i]) min = sequence[i];
                    else continue;
                }
                Console.WriteLine($"v.1 Min value = {min}");

                //Second example
                Array.Sort(sequence);
                Console.WriteLine($"v.2 Min Value = {sequence[0]}");
            }
            else if (choose == 3)
            {
                //Task #3
                Random r = new Random();
                Console.Write("Input max value:");
                int max = int.Parse(Console.ReadLine());
                
                int secretNumber = r.Next(max);

                Console.WriteLine("Try to guess the number: ");
                while(true)
                {
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput < secretNumber)
                    {
                        Console.WriteLine("The secret number is grater than, try again");
                    }
                    else if (userInput > secretNumber)
                    {
                        Console.WriteLine("The secret number is less than, try again");
                    }
                    else if (userInput == secretNumber)
                    {
                        Console.WriteLine("Congratulations you guessed it!");
                        break;
                    }
                }
            }

        }
    }
}
