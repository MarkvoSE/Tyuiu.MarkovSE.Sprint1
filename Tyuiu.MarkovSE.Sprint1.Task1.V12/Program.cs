﻿using Tyuiu.MarkovSE.Sprint1.Task1.V12.Lib;
namespace Tyuiu.MarkovSE.Sprint1.Task1.V12
{
    internal class Program
    {
            static void Main(string[] args)
            {
                DataService ds = new DataService();
                Console.Title = "Спринт #1 | Выполнил: Марков С.Е. | ИСПб-24-1";
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("* Спринт #1                                                                       *");
                Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                         *");
                Console.WriteLine("* Задание #1                                                                      *");
                Console.WriteLine("* Вариант #12                                                                     *");
                Console.WriteLine("* Выполнил: Марков Савелий Евгеньевич | ИСПб-24-1                                 *");
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                        *");
                Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,         *");
                Console.WriteLine("* вычисляет результат по формуле (x+y)/6 и печатает его на экран                  *");
                Console.WriteLine("*                                                                                 *");
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
                Console.WriteLine("***********************************************************************************");

                double x, y;

                Console.WriteLine("Введите значение X:");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение Y:");
                y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
                Console.WriteLine("***********************************************************************************");

                Console.WriteLine(ds.Calculate(x, y));

                Console.ReadLine();
        }
    }
}

