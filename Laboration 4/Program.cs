using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Wall wall1 = new Wall(0, 0);
            Console.WriteLine(wall1.MapSymbol);
            Console.ReadLine();
        }
    }
}
