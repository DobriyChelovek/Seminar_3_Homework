/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да


*/

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

