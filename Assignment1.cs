using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_Assignment
{
    class Assignment1
    {
        static void Main(string[] args)
        {
            displayRange();
        }

        private static void displayRange()
        {
            Console.WriteLine("range of signed int:"+int.MinValue+ " to " +int.MaxValue+"  range of unsigned int is " +uint.MinValue +" to "+uint.MaxValue );
            Console.WriteLine("range of signed byte:" + sbyte.MinValue + " to " + sbyte.MaxValue + " range of unsigned byte is " + byte.MinValue + " to " + byte.MaxValue);
            Console.WriteLine("range of signed short:" + short.MinValue + " to " + short.MaxValue + " range of unsigned short is " + ushort.MinValue + " to " + ushort.MaxValue);
            Console.WriteLine("range of signed long:" + long.MinValue + " to " + long.MaxValue + " range of unsigned long is " + ulong.MinValue + " to " + ulong.MaxValue);
            Console.WriteLine("range of float:" + float.MinValue + " to " + float.MaxValue + " range of double " + double.MinValue + " to " + double.MaxValue);

        }
    }
}


