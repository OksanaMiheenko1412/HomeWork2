// task13
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()); // ввод чисел  
if(a < 100)
    Console.Write("Третьей цифры нет");
else
{
    while (a > 1000)
        a = a / 10;
}    

Console.Write(a % 10); 