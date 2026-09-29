using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MotorinDA.Sprint1.Task3.V0.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double r, double h)
        {
            return 3.14 * r * r * h;
        }

    } 
}
