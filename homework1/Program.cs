Console.WriteLine("Введите число для проверки");
int a = Convert.ToInt32(Console.ReadLine());
if ( a % 23 == 0 & a % 7 == 0)
    {
        Console.WriteLine("да");
    }
else
    {
        Console.WriteLine("нет");
    }
