using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MarkovSE.Sprint1.Task3.V15.Lib
{
    public class DataService : ISprint1Task3V15
    {
        public double DistanceOverTime(double v1, double v2, double S, double T)
        {
            return Math.Round( S - ((v1 * T) + (v2 * T)), 3);
        }
    }
}
