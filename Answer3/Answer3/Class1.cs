using System;
using System.Collections.Generic;
using System.IO;

namespace Answer3
{
     public  class Class1
     {

        public static void Search(string input)
        {


            foreach (string file in Directory.GetFiles(input))

                Console.WriteLine("  -" + Path.GetFileName(file));

            foreach (string directory in Directory.GetDirectories(input))
            {

                Console.WriteLine("--" + Path.GetFileName(directory));
                Search(directory);
            }



        }
     }
}
