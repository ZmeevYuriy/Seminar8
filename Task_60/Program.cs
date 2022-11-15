// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

int Promt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}


void Calculation(int ar, int br, int cr)
{
    int index = ar * br * cr;
    if (index > 99)
    {
        Console.WriteLine($"Такого быть не может, так как двухзначных чисел только 99");
    }
    else 
    {
        int [,,] patric = new int [ar, br, cr];
        CreateArray(patric);
        Console.WriteLine("Полученный результат: ");
        PrintArray(patric);
    }
}


void CreateArray(int[,,] array)
{
    int[] rem = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for(int i = 0; i < rem.GetLength(0); i++)
    {
        rem[i] = new Random().Next(10, 100);
        number = rem[i];
        if (i >= 1)
        {
            for(int j = 0; j < i; j++)
            {
                while (rem[i] == rem[j])
                {
                    rem[i] = new Random().Next(10, 100);
                    j = 0;
                    number = rem[i];
                }
                number = rem[i];
            }
        }
    }

    int count = 0;
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            for(int hol = 0; hol < array.GetLength(2); hol++)
            {
                array[row, col, hol] = rem[count++];
            }
        }
    }
}


void PrintArray(int[,,] array)
{
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            for(int hol = 0; hol < array.GetLength(2); hol++)
            {
                Console.Write($"{array[row, col, hol]}({row}, {col}, {hol});");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int hol = Promt("Введите высоту: ");
int row = Promt("Введите кол-во строк: ");
int col = Promt("Введите кол-во столбцов: ");
Calculation(hol, row, col);

