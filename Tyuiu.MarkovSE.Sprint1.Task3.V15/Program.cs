using Tyuiu.MarkovSE.Sprint1.Task3.V15.Lib;
namespace Tyuiu.MarkovSE.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Марков С.Е. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Марков Савелий Евгеньевич | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v1;
            double v2;
            double S;
            double T;

            Console.WriteLine("Введите скорость 1 машины:");
            v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите скорость 2 машины:");
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите расстояние:");
            S = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите время в часах:");
            T = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между ними:" + ds.DistanceOverTime( v1,  v2,  S,  T));
            Console.ReadKey();

        }
    }
}