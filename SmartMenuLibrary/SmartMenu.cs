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
        List<string> lines = new List<string>();
        string titel = "";
        string explain = "";
        string[,] menu;
        public void LoadMenu(string path)
        {


        }
        public void Activate()
        {

            int choice = 0;
            bool running = true; 
            while (running != false)
            {

                
                Console.Clear();
                Console.WriteLine("Select language / Vælg sporg");

                Console.WriteLine("1. Dansk");
                Console.WriteLine("2. English");

                int danskengelsk = int.Parse(Console.ReadLine());
                switch (danskengelsk)
                {
                    case 1: //Dansk
                        int counter = 0;

                        // Read the file and display it line by line.  
                        System.IO.StreamReader file =
                            new System.IO.StreamReader(@"..\..\..\MenuSpec.txt");
                        while ((line = file.ReadLine()) != null)
                        {
                            lines.Add(line);
                            counter++;
                        }


                        titel = lines[0];
                        explain = lines[1];


                        //indlæs menupunkter
                        menu = new string[lines.Count - 2, 2];
                        for (int i = 2; i < lines.Count; i++)
                        {
                            string[] split = lines[i].Split(';');

                            menu[i - 2, 0] = split[0];
                            menu[i - 2, 1] = split[1];

                        }


                        file.Close();
                        break;
                    case 2: //English 
                        int counter1 = 0;

                        // Read the file and display it line by line.  
                        System.IO.StreamReader file1 =
                            new System.IO.StreamReader(@"..\..\..\MenuSpecEnglish.txt");
                        while ((line = file1.ReadLine()) != null)
                        {
                            lines.Add(line);
                            counter1++;
                        }


                        titel = lines[0];
                        explain = lines[1];


                        //indlæs menupunkter
                        menu = new string[lines.Count - 2, 2];
                        for (int i = 2; i < lines.Count; i++)
                        {
                            string[] split = lines[i].Split(';');

                            menu[i - 2, 0] = split[0];
                            menu[i - 2, 1] = split[1];

                        }


                        file1.Close();
                        break;
                    case 3: //Forkert input
                        if (danskengelsk > 2)
                        {
                            Console.WriteLine("The input is too high, enter lower number");
                        }
                        goto case 1;
                }

                Console.WriteLine(titel + "\n");

                Console.WriteLine(explain + "\n");

                // print alle menuerne
                for (int i = 0; i < menu.GetLength(0); i++)
                {
                    Console.WriteLine((i + 1) + ". " + menu[i, 0] + "\n");
                }

                string input = Console.ReadLine();


                if (input.ToLower() == "0")
                {
                    running = false;
                }
                else if (int.TryParse(input, out choice))
                {
                    choice -= 1;
                    //kald bindings klassen
                    if (choice < menu.GetLength(0))
                    {
                        Bindings.Call(menu[choice, 1]);
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
