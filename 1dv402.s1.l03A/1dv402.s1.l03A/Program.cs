using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402.s1.l03A
{
    class Program
    {
        static void Main(string[] args)
        {

            Salaries = ReadInt("Ange hur många löner som ska beräknas: ");
            ProcessSalaries(); 


       }

        static void ProcessSalaries(int count)
        {
            int[] salaries = new int[count];

            for (int i = 0; i < salaries.Length; i++)
            {
                salaries[i] = ReadInt(String.Format("Ange lön nr {0}: ", i + 1));
            }
            
        }

        static int ReadInt(string prompt) 
        {
            int input;           
            Console.Write(prompt);
            input = int.Parse(Console.ReadLine());
            return input;

        }
       
      
    }
}
