using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NefedovIS.Sprint1.Task2.V6.Lib
{
    public class DataService : ISprint1Task2V6
    {
        public double ConvertMToKm(int value)
        {
            return (value / 1000) + (value % 1000) * 0.001;
        }
    }
}
