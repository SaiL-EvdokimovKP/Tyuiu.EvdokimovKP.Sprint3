using Tyuiu.EvdokimovKP.Sprint3.Task3.V11.Lib;

DataService ds = new DataService();

string value = "sqwreq vqwqq q";
char replaceable = 'q';
char replacement = '7';

Console.WriteLine("Строка - " + value);
Console.WriteLine("Заменяема буква - " + replacement);
Console.WriteLine("Заменитель = " + replaceable);

Console.WriteLine("********************************************************************");
Console.WriteLine("Решение:                                                            ");
Console.WriteLine("********************************************************************");
Console.WriteLine("Строка с заменёнными символами - " + ds.ReplaceCharOnNum(value, replaceable, replacement));
Console.ReadKey();