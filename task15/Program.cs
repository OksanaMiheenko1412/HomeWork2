// task 15
Console.Clear();
Console.Write("Введите день недели: ");
int a = Convert.ToInt32(Console.ReadLine()); // ввод чисел
while (a < 1 || a > 7)
{
    Console.Write("Вы ошиблись!\aВведите день недели: ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a == 6 || a == 7)
    Console.Write("yes");
else
    Console.Write("no");    
