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
        string firstMenuPoint = "";
        string secondMenuPoint = "";
        string thirdMenuPoint = "";
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

            foreach (string temp in lines[2].Split(';'))
            {
                titel = lines[0];
                explain = lines[1];
                firstMenuPoint = "1. " + lines[2] + ": ";
                secondMenuPoint = "2. " + lines[3] + ": ";
                thirdMenuPoint = "3. " + lines[4] + ": ";
                counter++;
            }


            file.Close();
  

        }
        public void Activate()
        {
            Console.WriteLine(titel);

        }
    }
}
