using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            Console.WriteLine("how many students in the class?");
            int students = Convert.ToInt32(Console.ReadLine());
            int[] cls = new int [students];
            Double sum = 0;
            
            for (int i = 0; i < cls.Length; i++)
                 {
                    cls[i] = randomGenerator.Next(0, 100);
                    
                 }
           

            for (int i = 0; i < cls.Length; i++)
            {
                Console.WriteLine(cls[i]);
                sum = sum + cls[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum/cls.Length);



        }
    }
}
