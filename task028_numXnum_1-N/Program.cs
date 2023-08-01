// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int ProductNum(int num)
{
    int res = 1;    
    for(int i = 1; i < num; i++)
    {
        res = res * (i + 1);
        Console.WriteLine($"res{i}->{res}");
    }
    return res;
}

int number = Prompt("Enter number N: ");
int result = ProductNum(number);
Console.WriteLine($"Произведение чисел от 1 до {number} -> {result}");


//Альтернативное решение, с проверкой на переполнение типа int
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} -> {factorial}");

int Factorial(int num)
{
    int fac = 1;    
    for(int i = 1; i <= num; i++)
    {
        checked     //проверка на переполняемость типа int, будет выпадать ошибка,если будет переполнен 
        {
            fac *= i;
        }
    }
    return fac;
}
