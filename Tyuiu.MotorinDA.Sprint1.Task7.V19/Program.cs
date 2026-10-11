using Tyuiu.MotorinDA.Sprint1.Task7.V19.Lib;
namespace Tyuiu.MotorinDA.Sprint1.Task7.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Моторин Д.А. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Моторин Дмитрий Алексеевич | ИИПб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*            2                                                            *");
            Console.WriteLine("*          7x             4    5                                          *");
            Console.WriteLine("* z = x - ---- + sinX + |x  - x |                                         *");
            Console.WriteLine("*           3                                                             *");
            Console.WriteLine("*          x                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение Х:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x));
        }
    }
}
