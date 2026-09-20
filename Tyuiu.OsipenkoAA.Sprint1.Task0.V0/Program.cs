using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.OsipenkoAA.Sprint1.Task0.V0.Lib;
//Задание
//Написать программу, которая вычисляет выражение 10/(2+3) и печатает результат на экран

namespace Tyuiu.OsipenkoAA.Sprint1.Task0.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 Выполнила: Осипенко А.А. | ПКТБ-26-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*Спринт #1                                                                    *");
            Console.WriteLine("*Тема: Базовые навыки работы в C#                                             *");
            Console.WriteLine("*Задание #0                                                                   *");
            Console.WriteLine("*Вариант #0                                                                   *");
            Console.WriteLine("*Выполнила: Осипенко Анастасия Алексеевна |ПКТБ-26-1                          *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                     *");
            Console.WriteLine("*Написать программу, которая вычисляет выражение 10/(2+3 )                    *");
            Console.WriteLine("*И печатает результат на экран                                                *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*10/(2+3)                                                                     *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("*******************************************************************************");

            //Метод Calculate находится в библиотеке Tyuiu.OsipenkoAA.Sprint1.Task0.V0.Lib
            //в классе DataService
            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}
