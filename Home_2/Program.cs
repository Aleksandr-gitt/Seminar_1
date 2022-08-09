Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b) 
{
    if(a > c) 
    {
        Console.Write("max = " + a);
    }
    else 
    {
        Console.Write("max = " + c);
    }
}

if(a < b) 
{
    if(b > c) 
    {
        Console.Write("max = " + b);
    }

    else 
    {
        Console.Write("max = " + c);
    }
}

