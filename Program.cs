using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random mtr = new Random();
            int aa = 0;
            int bb = 0;
            int number = Convert.ToInt32(Console.ReadLine());
            
            int[,] matrix = new int [5, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,0] = mtr.Next(0, 10);
                    matrix[i,j] = mtr.Next(0, 10);
                    Console.Write(matrix[i,j]);

                    if (number == matrix[i, j])
                    {
                        aa = i + 1;
                        bb = j + 1;
                       
                    }
                    
                     

                }
                Console.WriteLine();
               
            }
            Console.Write("line:");
            Console.WriteLine(aa);
            Console.Write("column:");
            Console.WriteLine(bb);



        }
    }
}
