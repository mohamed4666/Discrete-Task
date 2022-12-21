using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfict_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int startingNumber , endingNumber;
            Console.WriteLine("                                     Get All Perfect In Range Of Btween two Number ");
            Console.WriteLine("                                     ----------------------- --------------------- ");

            Console.WriteLine("Enter Starting Number : ");
            startingNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ending Number : ");
            endingNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Below Are The Perfect Number Between " + startingNumber + " and " + endingNumber);

            for (int i = startingNumber; i <= endingNumber; i++)
            {
                decimal sum = 0;
                for (int j = 1; j < i; j++) 


                {
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == i)
                    Console.WriteLine("\t" + i);

            }
                Console.ReadKey();

            }
        }
          
 }
    

