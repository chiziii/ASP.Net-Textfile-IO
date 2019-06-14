using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assement
{
    class Program
    {
        //The path to the text file, where all data is saved
         string filepath = "C:\\Users\\DELL\\Desktop\\viva.txt";

        // Function that Reads out data from the text file
        public void ReadFromTextfile()
        {
            List<string> lines = File.ReadAllLines(filepath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        // Function that Saves data to the textfile
        public void SaveToTextfile()
        {
            List<string> lines = File.ReadAllLines(filepath).ToList();

            lines.Add(Console.ReadLine());


            File.WriteAllLines(filepath, lines);

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // instantiate the Program class and call it's functions
            Program program = new Program();
            program.ReadFromTextfile();
            program.SaveToTextfile();

            Console.ReadLine();
        }
    }
}


    /* string filepath = "C:\\Users\\DELL\\Desktop\\viva.txt";

          List<string> lines = File.ReadAllLines(filepath).ToList();

          foreach (string line in lines)
          {
              Console.WriteLine(line);
          }

           /*lines.Add("Name: Chizi" +
                     "Phone number: 252853526" +
                     "| Address: 23 Wealth avenue" +
                     "| Net worth: Forbes is still working on calculating this to include all her assets without leaving any out hbdfhbdhbsh");*/

   /* lines.Add(Console.ReadLine());


 File.WriteAllLines(filepath, lines);

 Console.WriteLine();



 Console.ReadLine(); */
