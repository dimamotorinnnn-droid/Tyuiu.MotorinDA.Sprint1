using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MotorinDA.Sprint1.Task5.V0.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double ress = (temp - 32) * 5 / 9;
            return (int)Math.Round(ress);
        }
    }
}
