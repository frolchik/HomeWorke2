/* Task1 Напишите программу, которая на вход принимает трёхзначное число 
и на выходе показывает вторую цифру*/

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("введите трехзначное число");
if(number < 100 || number >= 1000)
{
    Console.WriteLine("ошибка ввода");
    return;
}
Console.WriteLine($"введенное число {number}");
int secondnum = number / 10 % 10;
Console.WriteLine($"вторая цифра {secondnum}");

/* Task2 Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.*/

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetThirdNum(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool ValidateNumber (int number)
{
    if (number < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return false;
    }
    return true;
}
int number = Prompt("введите число ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdNum(number));
}

/*Task3. Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool IsWeekend(int day)
{
    if (day > 5)
    {
        return true;
    }
    return false;
}
bool ValidateDay (int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("ошибка ввода");
    return false;
}
int Day = Prompt("введите день недели ");
if (ValidateDay(Day))
{
    if (IsWeekend(Day))
    {
        Console.WriteLine("выходной день");
    }
    else
    {
        Console.WriteLine("будний день");
    }
}
