using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StreamReadWriter
{
    class Program
    {
        static void Main()
        {
            var writer = new StreamWriter("numbers.txt");  //Writes a loop result in a file into the computer

            using (writer)
            {
                for (int i = 0; i < 1000; i++)
                {
                    writer.Write(i + " ");
                }
            }
        }
    }
}
