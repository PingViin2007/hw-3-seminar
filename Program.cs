// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom(int num)
{
    if (num >= 10000)
    {
        int first = num / 10000;
        int fifth = num % 10;
 
        if(first == fifth)
        {
            int second = num / 1000 % 10;
            int fouth = num % 100 / 10;

            if(second == fouth)
            {
               Console.WriteLine("Число является палиндромом");
            }
        }
        else
        {
        Console.WriteLine("Число НЕ является палиндромом");
        }    
    }
    else
    {
    Console.WriteLine("Число не пятизначно");
    }
}
 
Console.WriteLine("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine()!);
Palindrom (num);












// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = 0;
    dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 -z1), 2));
    return dist;
}

Console.WriteLine("enter coordinate x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter coordinate y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter coordinate z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter coordinate x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter coordinate y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter coordinate z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, z1, x2, y2, z2);

Console.WriteLine(Math.Round(distance, 3));












// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int N)
{
    if (N > 0)
    {
        int count = 1;
        while (count <= N)
        {
            Console.Write(count * count * count + " ");
            count++;
        }
    }
    else
    {
        Console.WriteLine("Введите число больше 0");
    }
}
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Cube(N);

