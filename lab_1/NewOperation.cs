using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class NewOperation
    {
        public double newOperation()            //новая операция
        {
            double result = 0;
            double x, y;
            char operation;
            try
            {

                Console.WriteLine("Введите первое число");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите операцию");
                operation = Console.ReadLine()[0];
                Console.WriteLine("Введите второе число");
                y = Convert.ToDouble(Console.ReadLine());
                Calc calc = new Calc(x, y, operation);
                result = calc.selection(operation);
            }
            catch (Exception e)
            {
                Console.WriteLine("Введено неверное значение " + e.Message);
            }
            return result;
        }
    }
}
