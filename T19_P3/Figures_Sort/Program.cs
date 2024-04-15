using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            while (true) {



                Console.Write("\n1 - TRIANGLE\n2 - RCTANGLE \n3 - CIRCLE\n4 - All info \n 5 - Sort by Perimeter\n 6 - Sort By Square\n\n");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                char keyChar = keyInfo.KeyChar;
                switch(keyChar) {

                    case '1':
                        repository.TrianglePrint();
                       
                        break;

                    case '2':
                        repository.RectanglePrint();
                        break;

                    case '3':
                        repository.CirclePrint();  
                        break;

                    case '4':
                        Console.Clear();
                        repository.GetAll();
                        break;
                
                }

            }
        }
    }
}
