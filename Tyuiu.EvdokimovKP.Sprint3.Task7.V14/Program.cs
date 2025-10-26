using Tyuiu.EvdokimovKP.Sprint3.Task7.V14.Lib;

DataService ds = new DataService();

Console.WriteLine("**********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
Console.WriteLine("**********************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine("Начало = " + startValue);
Console.WriteLine("Конец = " + stopValue);

Console.WriteLine("+----------+-----------+");
Console.WriteLine("|    X     |    f(x)   |");
Console.WriteLine("+----------+-----------+");

int len = ds.GetMassFunction(startValue, stopValue).Length;
double[] res;
res = new double[len];
res = ds.GetMassFunction(startValue, stopValue);

for (int i = 0; i <= len; i++)
{
    Console.WriteLine("|{0, 5:d}     |  {1, 6:f2}   |", startValue, res[i]);
    startValue++;
}
Console.WriteLine("+----------+----------+");
Console.ReadKey();