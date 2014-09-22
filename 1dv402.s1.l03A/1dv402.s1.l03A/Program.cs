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
            int salariesInput = 0;
            salariesInput = ReadInt("Ange hur många löner som ska beräknas: ");

            while(salariesInput >= 2)
                try
                {

                    ProcessSalaries(salariesInput);
                    break;
                }
                catch
                {
                    Console.WriteLine("Du måste mata in minst 2 löner för att göra en beräkning!");
                }

                    

                

            Console.ReadKey();

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
