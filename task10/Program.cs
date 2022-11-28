// Task 10
Console.Clear();

int a = new Random().Next(100, 1000); // [100, 999]
Console.WriteLine($"Случайное число:  {a}"); // ввод трехзначного числа
int a2 = a % 100 / 10; //  нахождение десятков и вывод первой цифры 
Console.Write(a2 % 100 / 10);