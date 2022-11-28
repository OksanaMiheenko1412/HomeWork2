// task13
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()); // ввод чисел  
if(a > 100)
    Console.Write(a);
else
    Console.Write("Третьей цифры нет");

int a3 = a % 10;
Console.Write(a3 % 10); 