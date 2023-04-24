// Задача 19
// Напишите программу, которая принимает на вход число
// и проверяет, является ли оно палиндромом.

/*
bool Palindrom(int number)
{
    int modnum = number % 10;
    while(number != 0)
    {
        number /= 10;
        int dozent = number % 10;
        modnum = modnum * 10 + dozent;
    }
    
    if(number == modnum)
        return true;
    else return false;
}

Console.Write("Input a number ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = Palindrom(num);
if(result == true)
    Console.WriteLine("Yours numbers - palindromic");
else Console.WriteLine("Yours numbers - no palindromic");
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

/*
double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int a = x2 - x1;
    int b = y2 - y1;
    int c = z1 - z2;

    double result = Math.Sqrt(a * a + b * b + c * c);
    return result;
}

Console.Write ("Введите значение x1 - ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите значение y1 - ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите значение z1 - ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите значение x2 - ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите значение y2 - ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите значение z2 - ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distans = Dist(x1, y1, z1, x2, y2, z2);

Console.Write ($"Расстояние между точками 1 и 2 составляет - {distans}");
*/


// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube(int number)
{
    int count = 1;
    while(count <= number)
    {
        double cub = Math.Pow(count,3);
        count++;
        Console.Write(cub + " ");
    }
}

Console.Write("Input a number ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);
*/