using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                NewOperation newOp = new NewOperation();
                Console.WriteLine("Результат: " + newOp.newOperation() + '\n');
            }
        }
    }
}
