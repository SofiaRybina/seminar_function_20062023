// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

const int ARRAYSIZE = 8; //задаём размер массива
int[] randomBinArr = RandomBinaryArray(); // кладём результат метода рандомного заполнения
// массива в массив randomBinArr  
PrintArray(randomBinArr); // выводим полученный рандомный массив

int[] RandomBinaryArray()//тип метода возвращаемый массив
{
    int[]arr = new int[ARRAYSIZE];
    Random random = new Random(); //создаём класс рандом, чтобы в 18 строке он 
                                  //каждый раз не пересоздавался

    for(int i = 0; i < ARRAYSIZE; i++)
    {
        arr[i] = random.Next(0,2);
    }
    return arr;
}

void PrintArray(int[] collection)
{
    Console.Write("[");
    foreach(var element in collection) //цикл foreach проходит по всем элементам поступившего 
                                  //массива и кладёт их в переменную element, затем выводит на консоль,
                                  //выходит как только доходит до последнего элемента массива
    {
        Console.Write($"{element}");
    }
    Console.Write("]");
    Console.WriteLine();
}


