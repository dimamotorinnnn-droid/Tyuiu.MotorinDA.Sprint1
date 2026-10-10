using Tyuiu.MotorinDA.Sprint1.Task3.V1.Lib;
namespace Tyuiu.MotorinDA.Sprint1.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Моторин Д.А. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составнрго присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Моторин Дмитрий Алексеевич | ИИПб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Вычислить, объём цилиндра                                      *");
            Console.WriteLine("* Написать программу,которая вычисляет объем цилтндра                     *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: Радиус = 2 Высота = 3                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ: 37,68                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение Х:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Объем цилиндра равен: " + ds.CylinderVolume(x, y));
        }
    }
}
