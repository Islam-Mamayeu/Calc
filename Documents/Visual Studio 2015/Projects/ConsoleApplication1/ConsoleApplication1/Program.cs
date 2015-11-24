using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=0;
            double b=0;
            double result=0;
            bool flag = true;
            string[] command = null;
            string enteredline =null;

            Console.WriteLine("Input example (2 + 4) (exit to leave):");

           



            while (flag)
            {
                try
                {
                    enteredline = Console.ReadLine();
                    command = enteredline.Split(' ');
                    if (command.Length > 2)
                    {
                      

                        a = Int32.Parse(command[0]);
                        b = Int32.Parse(command[2]);



                        switch (command[1])
                        {
                            case "+":
                                result = a + b;
                                Console.WriteLine("Result:" + result);
                                break;
                            case "-":
                                result = a - b;
                                Console.WriteLine("Result:" + result);
                                break;
                            case "*":
                                result = a * b;
                                Console.WriteLine("Result:" + result);
                                break;
                            case "/":
                                result = a / b;
                                Console.WriteLine("Result:" + result);
                                break;
                            case "exit":
                                flag = false;
                                break;
                            default:
                                Console.WriteLine("Incorrect command please try again");
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {

                        Console.WriteLine("Incorrect format of input.. example (2 + 2)");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Message : " + e.Message);


                }

            }
        }
    }
}
