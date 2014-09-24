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

            //Klonar min array
            //klonar min array
            int[] copy = (int[])totalSalaries.Clone();

            int numberOfSalaries = 0;
            int median = 0;
            int avergageSalary = 0;
            int salarySpread = 0;

            //antal löner i arrayen räknas in i antalLoner
            numberOfSalaries = copy.Count();

            //kolla med hjälp av modulus om antal löner e ett jämnt eller ojämnt tal
            if (numberOfSalaries % 2 == 0)
            {
                // jämnt antal inmatade löner
                median = (copy[(numberOfSalaries / 2) - 1] + copy[(numberOfSalaries / 2)]) / 2;
                            }
            else
            {
                // udda antal inmatade löner
                median = copy[((numberOfSalaries - 1) / 2)];
                
            }
            
            //Räknar ut medellönen
            avergageSalary = (int)copy.Average();
            
            //Räknar ut lönespridningen
            salarySpread = copy.Max() - copy.Min();
            
            //Presenterar resultatet
            Console.WriteLine("---------------------------------");
            Console.WriteLine("{0, -15} {1, 10:c0}", "Medianlön:", median);
            Console.WriteLine("{0, -15} {1, 10:c0}", "Medellön:", avergageSalary);
            Console.WriteLine("{0, -15} {1, 10:c0}", "Lönespridning:", salarySpread);
            Console.WriteLine("---------------------------------");

                
            

            //Skriva ut de heltal som arrayen håller och presenterar 
            for (int i = 0; i < totalSalaries.Length; ++i)
            {
                
                if(i % 3 == 0)
                {
                    Console.WriteLine();
                    
                }
                Console.Write("{0, 8}", totalSalaries[i]);
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
