// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int CountNum(int num)
{
    Console.WriteLine($"Usernum->{num}");
    int i = 0;
    while(num >= 1)
    {
        num = num / 10;
        Console.WriteLine($"run{i}->{num}");
        i++;
    }
    return i;
}

int number = Prompt("Enter number: ");
int result = CountNum(number);
Console.WriteLine($"Результат-> {result}");