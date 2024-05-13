Console.WriteLine("Введите число INT32 от 1 до 2,147,483,647");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
int num3 = num1;
int counter = 0;
//Сколько нулей
while (num3 > 0){
    num2 = num1 % 10;
    counter = counter + 1;
    num3 = num3 / 10;
}
// Console.WriteLine("СЧЕТЧИК" + counter);
//кол-во итераций i 
int i = counter;
int delitel1 = 1;
while (i != 1){
    delitel1 = delitel1*10;
    i = i - 1;

//Делитель создан
}
//Console.WriteLine(num1 + "Delitel" + delitel1);
while (delitel1 > 0){
    num3 = num1;
    if(delitel1 > 1){
        num3 = num3 / delitel1;
        num3 = num3 % 10;
        Console.Write(num3 + " ,");
        delitel1 = delitel1 / 10;
    }
    else{
        num3 = num3 % 10;
        Console.Write(num3);
        delitel1 = delitel1 - 1;
    }
}
//Потрачено 2,5 часа на эту задачу пляха
