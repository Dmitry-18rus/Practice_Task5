// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, 
//которая принимает на вход целое число любой разрядности и на выходе показывает 
//третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет


Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
int n1 = n;
while (n1 / 10 > 1)
{
    n1 = n1 / 10;
    count++;
}
//Console.WriteLine("count = " + count);
double x = 10;
double y = count - 3 - 1;
double res1 = Math.Pow(x, y);
//Console.WriteLine($"{x} ^ {y} = {res1}");
double res2 = (n / (10 * (res1)));
//Console.WriteLine(res2);
double res3 = Math.Floor((res2%10));
int res4 = Convert.ToInt32(res3);
//Console.WriteLine(res3);
if (res4 == 0)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine(res4);
}