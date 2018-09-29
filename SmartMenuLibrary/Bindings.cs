
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary
{
     static class Bindings
    {

        public static void Call(string id)
        {
        


            switch (id)
            {
                case "this":
                    Console.WriteLine(Functions.DoThis());
                    break;

                case "that":
                    Console.WriteLine(Functions.DoThat());
                    break;

                case "something":
                    string temp = "";
                    while (true)
                    {
                        Console.Write("Please enter anything: ");
                        temp = Console.ReadLine();
                        if (temp.Length <= 0)
                        {
                            Console.WriteLine("Enter something!");

                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine(Functions.DoSomething(temp));
                    break;
                    
                   


                case "another":
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything() + "\n");
                    break;

                default:

                    break;

            }
        }
    }
}
