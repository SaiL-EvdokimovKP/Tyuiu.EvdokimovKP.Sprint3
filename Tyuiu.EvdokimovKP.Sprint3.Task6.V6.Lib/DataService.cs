﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.EvdokimovKP.Sprint3.Task6.V6.Lib
{
    public class DataService : ISprint3Task6V6
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int result = 0;
            int y = 10;
            int z;
            for (x = startValue; x <= stopValue; x++)
                for (int d = 1; d <= x; d++)
                    if (x % d == 0)
                        result += d;
            if (y <= result)
                z = result;
            return result;
        }
    }
}
