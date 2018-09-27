
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
                temp = Console.ReadLine();

                Console.WriteLine(Functions.DoSomething(temp));
            }

        }
    }
}
