Console.WriteLine ("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b )
{
    Console.WriteLine (a + " это самое большое число ");
    Console.WriteLine (b + " это самое маленькое число ");
}
if (b > a )
{
    Console.WriteLine (b + " это самое большое число");
    Console.WriteLine (a + " это самое маленькое число ");
}