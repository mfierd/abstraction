using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction.Interface
{
    public class Kucing : IHewan
    {
        public void bunyi()
        {
            Console.WriteLine("kucing berbunyi meoww..");
        }
    }
}
