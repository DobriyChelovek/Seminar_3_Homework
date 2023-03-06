/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

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
Print($"Number :{number}");


int number1;
int reverse = 0;

int Revnum()
{
    while (number >0)
{
    number1 = number%10;
    reverse = (reverse*10 +number1);
    number = number /10;
}
return reverse;
}
int reverse2 = Revnum();
Print($"Reverse2 :{reverse2}");
Print($"Number2 :{number}");
    
         if (number == reverse2)
         {
            Print($"Число {number} является палиндромом");
         }
         
         {
            Print($"Число {number} не является палиндромом");
         }
        
   
Print($"{number}");
Print($"{reverse2}");

