
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
            //if (id == "polyline")
            //{
            //    Console.WriteLine(Functions.DoThis());
            //}

            //else if (id == "rectanglearea")
            //{
            //    Console.WriteLine(Functions.DoThat());
            //}

            //else if (id == "listofnumbers")
            //{
            //    Console.WriteLine("please write something");
            //    string temp = "";
            //    while (true)
            //    {
            //        temp = Console.ReadLine();
            //        if (temp.Length <= 0)
            //        {
            //            Console.WriteLine(Functions.DoSomething(temp));
            //        }
            //        else break;
            //    }
                
            //}            


            switch (id)
            {
                case "polyline":
                    Console.WriteLine(Functions.DoThis());
                    break;

                case "rectanglearea":
                    Console.WriteLine(Functions.DoThat());
                    break;

                case "listofnumbers":
                    string temp = "";
                    while (true)
                    {
                        Console.Write("Please enter something: ");
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
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    break;

            }
        }
    }
}
