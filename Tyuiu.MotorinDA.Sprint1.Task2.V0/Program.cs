using Tyuiu.MotorinDA.Sprint1.Task2.V0.Lib;
namespace Tyuiu.MotorinDA.Sprint1.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Моторин Д.А. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Моторин Дмитрий Алексеевич | ИИПб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Вычислить, сколько минут прошло с начала суток                 *");
            Console.WriteLine("* Написать программу,которая вычисляет сколько минут прошло с начала суток*");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: 1 час 20 минут                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ: 80 минут                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение Х:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            int y = int.Parse(Console.ReadLine());  
            Console.WriteLine("С начала суток прошло: " + ds.CalculateMinutesSinceStart(x, y) + " минут");
        }
    }
}
