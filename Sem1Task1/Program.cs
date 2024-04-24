Console.WriteLine("Введите число N: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 1 - num1;
while (num2 < num1)
{
    Console.Write(num2);
    num2++;
}