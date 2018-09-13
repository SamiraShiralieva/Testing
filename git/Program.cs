using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Выберите операцию:
            1 - Сложение 
            2 - Вычитание 
            3 - Умножение 
            4 - Деление");  
   string c = Console.ReadLine();
            double a, b;
            Console.WriteLine(' ');
            Console.WriteLine("Введите первое значение");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine(' ');  
            if (c == "1")
            {
                Console.WriteLine("Результат сложения = {0}", a + b);
            }
            if (c == "2")
            {
                Console.WriteLine("Результат вычитания = {0}", a - b);
            }  
            if (c == "4")
            {
                Console.WriteLine("Результат деления = {0}", a / b);
            }
                
        }
    }
}
