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
        string menuPoint = "";
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

            for (int i = 2; i < lines.Length; i++)
            {
                tempString = lines[i].Split(';');
                menuPoint =  "1. " + tempString[0] + ": ";
                menuPoint += "\n" + "2. " + tempString[2] + ": "; 

              
                
            }
                
                counter++;
            


            file.Close();
  

        }
        public void Activate()
        {
          
            Console.WriteLine(titel + "\n");

            Console.WriteLine(explain + "\n");

            Console.WriteLine(menuPoint + "\n");

            int point = int.Parse(Console.ReadLine());
            
            switch (point)
            {
                case 0:
                    exit = true;
                    break;


                case 1:

                    break;


                case 2:

                    break;

                case 3:

                    break;

                default:
                    break;
            }
}

        }
    }
}
