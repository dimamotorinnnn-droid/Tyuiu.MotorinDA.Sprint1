using System.ComponentModel;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MotorinDA.Sprint1.Task4.V0.Lib
{
    public class DataService : ISprint1Task4V28
    {
        public double Calculate(double x, double y)
        {
            var res = (Math.Cos(x * 3.14 / 2)) / (Math.Exp(2 * x + y));
            return res;
        }
    }
}
