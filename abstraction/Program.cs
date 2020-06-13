using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using abstraction.abstractClass;
using abstraction.Interface;

namespace abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hewan hewan;

            hewan = new Kucing();
            hewan.bunyi();

            Console.WriteLine();
            hewan = new Ayam();
            hewan.bunyi();

            Console.ReadKey();*/

            IHewan hewan;

            hewan = new Kucing();
            hewan.bunyi();

            Console.WriteLine();
            hewan = new Ayam();
            hewan.bunyi();

            Console.ReadKey();
        }
    }
}
