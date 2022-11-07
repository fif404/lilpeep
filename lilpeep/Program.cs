//Скрипников вар 17 3.4
double x = 0.1;
double y = 0;
do
{
    y = Math.Pow(x, 2) - Math.Sin(Math.PI) * x;
}
while ((x += 0.2) <= 2.9);
Console.WriteLine("Ответ:" + y);