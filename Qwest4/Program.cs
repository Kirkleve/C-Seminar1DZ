//Задача 4: Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все чётные
//числа от 1 до N.


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = N%2;

while (a <= N)
{
    if ((a % 2) == 0)
    {
        a = a + 2;
        Console.Write( a + " ");
    
    }
    else
    {
        a++;
    }
}
  
