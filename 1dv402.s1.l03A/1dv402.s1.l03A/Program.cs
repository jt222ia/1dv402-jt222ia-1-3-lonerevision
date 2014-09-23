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
            Console.WriteLine();
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
            
            
            //Sorterar Arrayen
            Array.Sort(totalSalaries);

            int numberOfSalaries = 0;
            int median = 0;
            int avergageSalary = 0;
            int salarySpread = 0;

            //antal löner i arrayen räknas in i antalLoner
            numberOfSalaries = totalSalaries.Count();

            //kolla med hjälp av modulus om antal löner e ett jämnt eller ojämnt tal
            if (numberOfSalaries % 2 == 0)
            {
                // Vid jämnt antal
                median = (totalSalaries[(numberOfSalaries / 2) - 1] + totalSalaries[(numberOfSalaries / 2)]) / 2;
                            }
            else
            {
                // Vid udda antal
                median = totalSalaries[((numberOfSalaries - 1) / 2)];
                
            }
            
            //Räknar ut medellönen
            avergageSalary = (int)totalSalaries.Average();
            
            //Räknar ut lönespridningen
            salarySpread = totalSalaries.Max() - totalSalaries.Min();
            
            //Presentera resultatet
            Console.WriteLine("---------------------------------");
            Console.WriteLine("{0, -15} {1, 10:c0}", "Medianlön:", median);
            Console.WriteLine("{0, -15} {1, 10:c0}", "Medellön:", avergageSalary);
            Console.WriteLine("{0, -15} {1, 10:c0}", "Lönespridning:", salarySpread);
            Console.WriteLine("---------------------------------");

            //klonar min array
            int[] copy = (int[])totalSalaries.Clone();

            //Sorterar om min array igen
            Array.Sort(copy);

            //Skriva ut de heltal som arrayen håller och presenterar 
            for (int i = 0; i < copy.Length; ++i)
            {
                Console.Write("{0, 8}", copy[i]);
                if((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                    
                }
                
            }            
            //Escape historien som jag inte fått til riktigt än
            
            
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
