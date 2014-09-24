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
            
            do
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
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Tryck på valfri tangent för att göra en ny beräkning - Escape avslutar");
                    Console.ResetColor();
                    Console.WriteLine();
            } 
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
           
            Console.ReadKey();

       }

        static void ProcessSalaries(int count)
        {
            int[] totalSalaries = new int[count];

            for (int i = 0; i < totalSalaries.Length; i++)
            {
                totalSalaries[i] = ReadInt(String.Format("Ange lön nr {0}: ", i + 1));
               
            }

            //klonar min array
            int[] copy = (int[])totalSalaries.Clone();

            //Sorterar Arrayen
            Array.Sort(totalSalaries);
                                
            //Deklarerar de variablar jag behöver till uträkningen
            int numberOfSalaries = 0;
            int median = 0;
            int avergageSalary = 0;
            int salarySpread = 0;

            //Antal löner i arrayen räknas in i antalLoner
            numberOfSalaries = copy.Count();

            //Kolla med hjälp av modulus om antal löner e ett jämnt eller ojämnt tal
            if (numberOfSalaries % 3 == 0)
            {
                //Jämnt antal inmatade löner
                median = (copy[(numberOfSalaries / 2) - 1] + copy[(numberOfSalaries / 2)]) / 2;
                            }
            else
            {
                //Udda antal inmatade löner
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
            Console.WriteLine();

             
            //Skriva ut de heltal som arrayen håller och presenterar 
            for (int i = 0; i < copy.Length; ++i)
            {
                
                if(i % 3 == 0)
                {
                    Console.WriteLine();
                    
                }
                Console.Write("{0, 8}", copy[i]);
            }                                           
        }

        static int ReadInt(string prompt) 
        {
           int input;
           
           while(true)
           {
               try
               {

                   Console.Write(prompt);
                   input = int.Parse(Console.ReadLine());
                   break;
               }
               catch (FormatException)
               {
                   Console.WriteLine();
                   Console.BackgroundColor = ConsoleColor.Red;
                   Console.ForegroundColor = ConsoleColor.White;
                   Console.WriteLine("FEL! Felaktigt format på inmatningen. Ange ett heltal( 1, 2, 5, 7 tex!");
                   Console.ResetColor();
               }
               catch 
               {
                   Console.BackgroundColor = ConsoleColor.Red;
                   Console.WriteLine("Okänt fel. Försökt igen.");
                   Console.ResetColor();
               }
               Console.WriteLine();
           }
           
           return input;
        }
       
      
    }
}
