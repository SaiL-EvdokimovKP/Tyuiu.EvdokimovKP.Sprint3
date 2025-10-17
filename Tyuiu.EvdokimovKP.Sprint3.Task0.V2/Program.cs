using Tyuiu.EvdokimovKP.Sprint3.Task0.V2.Lib;

DataService ds =  new DataService();

Console.WriteLine("********************************************************************");
Console.WriteLine("Переменные:                                                         ");
Console.WriteLine("********************************************************************");
int startValue = 1;
int stopValue = 9;

Console.WriteLine("Старт шаг = " + startValue);
Console.WriteLine("Стоп = " +  stopValue);

Console.WriteLine("********************************************************************");
Console.WriteLine("Решение:                                                            ");
Console.WriteLine("********************************************************************");

Console.WriteLine(ds.GetMultiplySeries(startValue, stopValue));