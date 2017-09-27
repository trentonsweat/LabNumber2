using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;

            while (ProgramContinue == true)
            {
                //input


                int num;
                Console.WriteLine("Enter A Number Between 1 and 100:");
                num = int.Parse(Console.ReadLine());

                if (num % 2 != 0)
                {
                    Console.WriteLine(num + "Odd ");
                }

                else
                {



                    if (num <= 25)
                    {
                        Console.WriteLine(num + "Even and less than 25");
                    }

                    else if (num >= 26 && num <= 60)
                    {
                        Console.WriteLine("Even ");

                        string UserChoice;
                        Console.WriteLine("Do you want to run the code again? (N/No/y/yes)");
                        UserChoice = Console.ReadLine();
                        if (UserChoice == "N" || UserChoice == "No")
                        {
                            ProgramContinue = false;
                        }
                    }
                }

            }
        }
    }
}
            
