using Tyuiu.EvdokimovKP.Sprint3.Task6.V6.Lib;

DataService ds = new DataService();

int startValue = 16;
int stopValue = 24;
Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));