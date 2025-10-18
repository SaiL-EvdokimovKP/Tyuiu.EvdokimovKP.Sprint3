﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.EvdokimovKP.Sprint3.Task1.V13.Lib
{
    public class DataService : ISprint3Task1V13
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double i = 1;
            while (startValue <= stopValue)
            {
                i = i * Math.Pow(1 / Math.Pow(value, startValue), -1);
                startValue++;
            }
            return Math.Round(i , 3);
        }
    }
}
