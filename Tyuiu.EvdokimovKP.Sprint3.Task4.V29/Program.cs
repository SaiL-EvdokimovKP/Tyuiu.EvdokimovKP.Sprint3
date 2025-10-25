using Tyuiu.EvdokimovKP.Sprint3.Task4.V29.Lib;

DataService ds  = new DataService();

Console.WriteLine("********************************************************************");
Console.WriteLine("Исходные данные:                                                    ");
Console.WriteLine("********************************************************************");

int startValue = -5;
Console.WriteLine("Начало" + startValue);
int stopValue = 5;
Console.WriteLine("Начало" + stopValue);

Console.WriteLine(ds.Calculate(startValue, stopValue));