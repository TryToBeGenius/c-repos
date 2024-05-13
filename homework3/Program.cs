Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 10 || num1 > 99){
    Console.WriteLine("Неверный ввод. Введите число от 10 до 99");
}
else{
    if (num1 % 10 > num1 / 10){
        Console.WriteLine(num1 % 10);
    } 
    else{
        Console.WriteLine(num1 / 10);
    }
}