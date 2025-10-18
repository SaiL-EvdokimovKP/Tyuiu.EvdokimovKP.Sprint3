using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.EvdokimovKP.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double i = 1;
            do
            {
                i = i * (Math.Pow(300 / (startValue + Math.Pow(value, startValue)), startValue));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(i, 3);
        }
    }
}
