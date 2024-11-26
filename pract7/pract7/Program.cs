// задание 1
void MasivMax()
{
    // создание массива
    int[] mas1 = { 987, 92, 5, 87, 34, 7621, 4 };
    int[] mas2 = { 97, 59, 55, 897, 56, 721, 96 };
    // вывод
    Console.WriteLine("Первый масив:");
    foreach (int i in mas1)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine("\r\n");
    Console.WriteLine("\r\nВторой масив:");
    foreach (int m in mas2)
    {
        Console.Write($"{m} ");
    }
    // работа с Array
    // по возрастанию
    Console.WriteLine("\r\n");
    Console.WriteLine("\r\nМасив 1 по возрастанию:");
    Array.Sort(mas1);
    foreach (int m1 in mas1)
    {
        Console.Write($"{m1} ");
    }
    //по убыванию
    Console.WriteLine("\r\n");
    Console.WriteLine("\r\nМасив 2 по убыванию:");
    Array.Sort(mas2);
    Array.Reverse(mas2);
    foreach (int m2 in mas2)
    {
        Console.Write($"{m2} ");
    }
    // Соединение
    int[] mas3 = new int[ mas1.Length + mas2.Length ];
    Array.Copy(mas1, mas3, mas2.Length);
    Array.Copy(mas2, 0, mas3, mas1.Length, mas2.Length);
    Console.WriteLine("\r\n");
    Console.WriteLine("\r\nCоединение Масивов:");
    foreach (int m3 in mas3)
    {
        Console.Write($"{m3} ");
    }
}
MasivMax();
//задание 2
void ABS()
{
    Console.WriteLine("\r\nАбсолютная разница между n и 123");
    Console.WriteLine("Введите целое число n:");
    int n = Convert.ToInt32(Console.ReadLine());
    int ras1 = Math.Abs(n - 123);
    if (n > 123)
    {
        int ras2 = ras1 * 3;
        Console.WriteLine($"Абсолютная тройная разность равна: {ras2}");
    }
    else if (n == 123)
    {
        Console.WriteLine("Абсолютная разность равна: 0");
    }
    else if (n < 123)
    {
        Console.WriteLine($"Абсолютная разность равна: {ras1}");
    }
}
ABS();