using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Calc
    {
        private double x;            //первый операнд
        private double y;                 //второй операнд
        private char operation;            //операция

        public Calc(double x, double y, char operation)    //конструктор
        {
            this.x = x;
            this.y = y;
            this.operation = operation;
        }

        public Calc()                              //пустой конструктор
        {
            x = 0;
            y = 0;
            operation = '+';
        }

        public double sum(double x, double y)                   //сумма
        {
            return x + y;
        }

        public double sub(double x, double y)                    //вычитание
        {
            return x - y;
        }

        public double mul(double x, double y)                              //умножение
        {
            return x * y;
        }

        public double div(double x, double y)                           //деление
        {
            try
            {
                if (y == 0) throw new Exception();
                return x / y;
            }
            catch (Exception e)
            {
                Console.WriteLine("Деление на ноль " + e.Message);
            }
            return 0;
        }

        public double selection(char ch)                          //выбор операции
        {
            double result = 0;
            try
            {
                switch (ch)
                {
                    case '+': result = sum(x, y); break;
                    case '-': result = sub(x, y); break;
                    case '*': result = mul(x, y); break;
                    case '/': result = div(x, y); break;
                    default: throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Неправильно выбрана операция " + e.Message);
            }
                return result;
            
        }
    }
}
