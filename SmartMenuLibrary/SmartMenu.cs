using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SmartMenuLibrary
{
    public class SmartMenu
    {

        string line;
        string[] lines = new string[5];
        string titel = "";
        string explain = "";
        string[,] menu;
        bool exit = false;
        public void LoadMenu(string path)
        {
            int counter = 0;


            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"..\..\..\MenuSpec.txt");
            while ((line = file.ReadLine()) != null)
            {
                lines[counter] = line;
                counter++;
            }

            string[] tempString = new string[5];
            titel = lines[0];
            explain = lines[1];
            int count = 1;


            //indlæs menupunkter
            menu = new string[lines.Length - 2, 2];
            for (int i = 2; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                // menu title
                menu[i - 2, 0] = split[0];
                // menu ID
                menu[i - 2, 1] = split[1];

            }


            file.Close();


        }
        public void Activate()
        {

            int choice = 0;
            while (true)
            {

                Console.Clear();

                Console.WriteLine(titel + "\n");

                Console.WriteLine(explain + "\n");

                // print alle menuerne
                for (int i = 0; i < menu.GetLength(0); i++)
                {
                    Console.WriteLine((i + 1) + ". " + menu[i, 0]);
                }

                string input = Console.ReadLine();


                if (input == "0")
                {
                    break;
                }
                else if (int.TryParse(input, out choice))
                {
                    choice -= 1;

                    //kald bindingsklassen
                    if (choice < menu.GetLength(0))
                    {

                    } else
                    {
                        Console.WriteLine("The number you put in is too high, choose one from the description");

                    }
                }

                else if (input.Length <= 0)
                {
                    Console.WriteLine("Please enter a number");
                } else
                {
                    Console.WriteLine("that is not a number, please enter a number ");
                }

                Console.ReadLine();





            }
        }
    }
}
