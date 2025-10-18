using Tyuiu.EvdokimovKP.Sprint3.Task2.V12.Lib;

DataService ds = new DataService();

Console.WriteLine("********************************************************************");
Console.WriteLine("Переменные:                                                         ");
Console.WriteLine("********************************************************************");
int startValue = 1;
int stopValue = 5;
int value = 5;

Console.WriteLine("Старт шаг = " + startValue);
Console.WriteLine("Стоп = " + stopValue);
Console.WriteLine("n = " + value);

Console.WriteLine("********************************************************************");
Console.WriteLine("Решение:                                                            ");
Console.WriteLine("********************************************************************");

Console.WriteLine(ds.GetMultiplySeries(value, startValue, stopValue));