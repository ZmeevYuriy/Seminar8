// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.

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


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}


void MinSumLineElement(int[,] array)
{
int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
}


int n = Promt("Введите кол-во строк");
int m = Promt("Введите кол-во столбцов");
int[,] array = CreateArray(n, m, 1, 10);
Console.WriteLine("Вот наш массив");
PrintArray(array);
MinSumLineElement(array);


