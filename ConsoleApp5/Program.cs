using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    //Michael Heimburgers simple calc 1
    class Program
    {
        static void Main(string[] args)
        {
            //Entry Message
            Console.WriteLine("calcTestOne1k press enter to start");
            Console.ReadLine();
            Console.Clear();

            string express = "";
            string exit = "no";
            int output = 0;
            bool modBool = true;

            //Operation Input
            while (exit.Equals("no"))
            {
                Console.WriteLine("Please input your expression in the format x  operator y ");
                express = Console.ReadLine();
                //seperating the operators and numbers
                string[] opCal = express.Split(' ');
                int nOne = int.Parse(opCal[0]);
                string opDecider = opCal[1];
                int nTwo = int.Parse(opCal[2]);

                switch (opDecider)
                {
                    case ("+"):
                        Console.WriteLine(nOne + nTwo);
                        break;
                    case ("*"):
                        Console.WriteLine(nOne * nTwo);
                        break;
                    case ("-"):
                        Console.WriteLine(nOne - nTwo);
                        break;
                    case ("/"):
                        output = nOne / nTwo;
                        int remainder = nOne % nTwo;
                        // remainder "simplifying"

                        bool looper = false;
                        do
                        {

                            if ((remainder % 2 == 0) && (nTwo % 2 == 0))
                            {
                                remainder /= 2;
                                nTwo /= 2;
                                looper = true;
                            }
                            else if ((remainder % 3 == 0) && (nTwo % 3 == 0))
                            {
                                remainder /= 3;
                                nTwo /= 3;
                                looper = true;
                            }
                            else if ((remainder % 5 == 0) && (nTwo % 5 == 0))
                            {
                                remainder /= 5;
                                nTwo /= 5;
                                looper = true;
                            }
                            else if ((remainder % 7 == 0) && (nTwo % 7 == 0))
                            {
                                remainder /= 7;
                                nTwo /= 7;
                                looper = true;
                            }
                            else
                            {
                                looper = false;
                            }

                        } while (looper);


                        // final output
                        Console.WriteLine("{0} and {1}/{2}", output, remainder, nTwo);
                        break;
                }
                Console.WriteLine("press enter to calculate again or type quit to quit");
                string quit = Console.ReadLine();
                Console.Clear();
                if (quit == "quit")
                {
                    return;
                }







            }
        }
    }                
}
