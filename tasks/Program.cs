/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

string? GetNUmber()
{
    Console.WriteLine("Введите пятизначное число");
    string? a = Console.ReadLine();
    return a;
}
string? b = GetNUmber();
int c = Convert.ToInt32(b);
bool CheckFor5()
{
    if (c < 99999 && c > 10000)
    {
        return true;
    }
    System.Console.WriteLine("Это не пятизначное число");
    return false;
}
if (CheckFor5())
{
    bool CheckNum()
    {
        if (b[0] == b[4] && b[1] == b[3])
        {
            System.Console.WriteLine($"Число {b} является палиндромом");
            return true;
        }
        else
        {
            System.Console.WriteLine($"Число {b} НЕ является палиндромом");
            return false;
        }

    }

    CheckNum();
}

                            Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


double x1 = 3;
double x2 = 2;
double y1 = 6;
double y2 = 1;
double z1 = 8;
double z2 = -7;

double distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

System.Console.WriteLine(distance);

                                Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт
таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

double retnum()
{
    System.Console.WriteLine("Введите число");
    string? a = (Console.ReadLine());
    double b = Convert.ToDouble(a);
    return b;
}

double N = retnum();
double result;

void cubedef()
{
    for (int i = 1; i <= N; i++)
    {
        result = Math.Pow(i,3);
        Console.Write($"{result}, ");       
    }
    
}
cubedef();