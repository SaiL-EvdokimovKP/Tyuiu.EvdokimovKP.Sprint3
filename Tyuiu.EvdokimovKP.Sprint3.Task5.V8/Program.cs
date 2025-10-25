using Tyuiu.EvdokimovKP.Sprint3.Task5.V8.Lib;

DataService ds = new DataService();

int x = 3;
int startValue1 = 1;
int startValue2 = 1;
int stopValue1 = 3;
int stopValue2 = 12;

Console.WriteLine("********************************************************************");
Console.WriteLine("Переменные:                                                         ");
Console.WriteLine("********************************************************************");
Console.WriteLine(startValue1);
Console.WriteLine(startValue2);
Console.WriteLine(stopValue1);
Console.WriteLine(stopValue2);
Console.WriteLine(x);
Console.WriteLine("y = " + ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2));
Console.ReadKey();
