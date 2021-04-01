using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_emp
{
    class Program
    {
        enum emp : int
        {
            John,
            Maria,
            Mary = 5,
            Peter,
            Jack = 10,
            Zoe
        }

        static void Main(string[] args)
        {
            Console.Write((int)emp.Maria + ", ");
            Console.Write((int)emp.Peter + ", ");
            Console.Write((int)emp.Jack + ", ");
            Console.Write((int)emp.Zoe);
            Console.ReadKey();
        }
    }
}

