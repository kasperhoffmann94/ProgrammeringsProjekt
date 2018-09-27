
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary
{
    class Bindings
    {

        public string Call(string id)
        {
            if (id == "polyline")
            {
                Console.WriteLine(Functions.DoThis());
            }

            else if (id == "rectanglearea")
            {
                Console.WriteLine(Functions.DoThat());
            }

            else if (id == "listofnumbers")
            {
                Console.WriteLine("please write something");
                string temp = "";
                while (true)
                {
                    temp = Console.ReadLine();
                    if (temp.Length <= 0)
                    {
                        Console.WriteLine(Functions.DoSomething(temp));
                    }
                    else break;
                }
                
            }            
        }
    }
}
