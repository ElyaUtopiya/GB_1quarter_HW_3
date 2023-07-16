// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
string number = Console.ReadLine();
int Chis = number.Length;

if (Chis == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Это число Палиндром");
    }
    else
    {
        Console.WriteLine($"Это число НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: число {number} - не является пятизначным");
}

// Задача 21.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double LongLineAB_3D (int xA, int xB, int yA, int yB, int zA, int zB)
{
    double longLine = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
    longLine = Math.Round(longLine, 2);
    return longLine;
}

Console.Write("Введите X координату точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки A: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X координату точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = LongLineAB_3D(xA,xB, yA, yB, zA, zB);
Console.WriteLine($"Расстояние между точкой A ({xA}, {yA}, {zA}) и точкой Б ({xB}, {yB}, {zB}): {dist}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(i*i*i);
        if (i < number) Console.Write(", ");
        else if (i == number) Console.Write(".");
        if (i % 5 == 0) Console.WriteLine();
        
    }
    Console.WriteLine();
}

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Cube(userNumber);
