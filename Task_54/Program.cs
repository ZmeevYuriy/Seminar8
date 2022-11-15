// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.


int Promt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

// Создаем функцию криэт которая ссоздает массив
int[,] CreateArray(int n, int m, int min, int max)
{
    int[,] a = new int[n, m];
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < m; col++)
        {
            a[row, col] = new Random().Next(min, max+1);
        }         
        
    }
    return a;
}

// Создаем метод которыЙ будет печатать нам наш массив в консоль
void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col]} ");
        }
        Console.WriteLine();
    }
}



void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}




int n = Promt("Введите кол-во строк");
int m = Promt("Введите кол-во столбцов");
int[,] array = CreateArray(n, m, 1, 10);
Console.WriteLine("Вот наш массив");
PrintArray(array);

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(array);
WriteArray(array);