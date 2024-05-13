Console.WriteLine("Введите число x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y ");
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0){
    Console.WriteLine("Координаты не должны находиться в нулевой точке");
}
else{
    if (x > 0 && y > 0){
        Console.WriteLine("1");
    }
    else if (x < 0 && y < 0){
        Console.WriteLine("3");
    }
    else if (x < 0 && y > 0){
        Console.WriteLine("2");
    }
    else if (x > 0 && y < 0){
        Console.WriteLine("4");
    }
}
