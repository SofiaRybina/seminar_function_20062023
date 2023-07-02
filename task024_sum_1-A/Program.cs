// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int GetSum(int number)
{
    int sum = 0;
    for(int i = 0; i <= number; i++)
    {
        sum += i;//sum = sum + i;
        //Console.Write(i + " ");
    }
    //Console.WriteLine(""); // пустая строка
    //Console.WriteLine($"{number} -> {sum}");
    return sum;
}

int A = Prompt("Enter number: ");
int result = GetSum(A);
Console.WriteLine($"Сумма чисел от 1 до {A} -> {result}");