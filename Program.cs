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


                var reader = new StreamReader(@"..\File1.txt");   ///Reading from File 
                using (reader)
                {
                    string currentLine = reader.ReadLine();
                    int count = 1;
                    while (currentLine != null)
                    {
                        Console.WriteLine("{0}. {1}", count, currentLine);
                        count++;
                        currentLine = reader.ReadLine();
                    }
                }


                var writer = new StreamWriter("numbers.txt");  //Writes a loop result in a file into the computer

                using (writer)  /Writing result in a File //
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        writer.Write(i + " ");
                    }
                }
            }
        }
    }

}
        }
    }
}
