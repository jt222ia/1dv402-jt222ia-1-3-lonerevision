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
            if (salariesInput >= 2)
            {
                ProcessSalaries(salariesInput);
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("FEL! Du måste minst ange 2 löner för att beräkna");
                Console.ResetColor();
            }


            Console.ReadKey();

       }

        static void ProcessSalaries(int count)
        {
            int[] totalSalaries = new int[count];

            for (int i = 0; i < totalSalaries.Length; i++)
            {
                totalSalaries[i] = ReadInt(String.Format("Ange lön nr {0}: ", i + 1));
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------");

            Array.Sort(totalSalaries);
            
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
