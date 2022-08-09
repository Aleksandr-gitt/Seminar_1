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

