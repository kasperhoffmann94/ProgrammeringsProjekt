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

           
                string[] tempString = new string[2];
                titel = lines[0];
                explain = lines[1];
                int count = 1; 
                for (int i = 2; i <lines.Length; i++)
                {
                tempString = lines[i].Split(';');
                firstMenuPoint = count + ". " + tempString[1] + ": ";
                secondMenuPoint = count + ". " + lines[i] + ": ";
                thirdMenuPoint = count + ". " + lines[i] + ": ";
                }
        
                counter++;
            


            file.Close();
  

        }
        public void Activate()
        {
            Console.WriteLine(titel);

            Console.WriteLine(firstMenuPoint);

        }
    }
}
