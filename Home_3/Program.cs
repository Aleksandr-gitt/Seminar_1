Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 2;

if(b == 0)
    {
    Console.Write("число " + a + " четное");
    }

else
{
   Console.Write("число " + a + " нечетное");
}
