/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

void Print(string message)
{
    Console.WriteLine(message);
}

int GetNUmber(string message)
{
    Console.WriteLine(message);
    string? a = Console.ReadLine();
    int b = Convert.ToInt32(a);
    return b;
}
int number = GetNUmber( "Введите положительное пятизначное число");

bool Check(int number)
{
    if (number>99999)
    {
        Console.WriteLine("Это не пятизначное число");
        return false;
    }
    return true;
}
bool Negative(int number)
{
    if (number<0)
    {
        Console.WriteLine("Введите положительное число");
        return false;
    }
    return true;
}
if (Check(number))
{
    if (Negative(number))
    {
         Print("работает");
    }
   
}
*/




