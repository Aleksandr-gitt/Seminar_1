Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 2)
{
    Console.Write("Повторите попытку. Введите число больше 1");
}

while(n > 1)
{
    int b = n % 2; 
    if(b == 0)
    {
    Console.Write(n + " ");
    }
    n = n - 1;  
}

