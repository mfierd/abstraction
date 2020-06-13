using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction.abstractClass
{
    public class Kucing : Hewan
    {
        public override void bunyi()
        {
            Console.WriteLine("kucing berbunyi meoww..");
        }
    }
}
