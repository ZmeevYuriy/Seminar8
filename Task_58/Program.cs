// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

int rowsA = Promt("Введите кол-во строк 1 массива: ");
int columnsA = Promt("Введите кол-во столбцов 1 массива: ");
int rowsB = Promt("Введите кол-во строк 2 массива: ");
int columnsB = Promt("Введите кол-во столбцов 2 массива: ");

int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);
PrintArray(A);
Console.WriteLine();
PrintArray(B);
Console.WriteLine();
PrintArray(GetMultiplicationMatrix(A,B));


int Promt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        } 
    }
      return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
       for (int j = 0; j < inArray.GetLength(1); j++)
       {
            Console.Write($"{inArray[i, j]} ");
       }
       Console.WriteLine();
    }
}

int [,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    if (columnsA != rowsB)
    {
        Console.WriteLine("Такие матрицы умножать нельзя!");
    }
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    {
        for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                for (int k = 0; k < arrayA.GetLength(1); k++)
                {
                    arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
                }
            }
        }
    }
    return arrayC;
}
  