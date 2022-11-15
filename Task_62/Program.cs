// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int M = Promt("Введите количество строк");
int N = Promt("Введите количество столбцов");
int Promt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
if (M == N)
{
    int[,] array = new int[M, N];
    int row = 0;
    int colom = 0;
    int matrixValue = 1;
    while (matrixValue <= M * N)
    {
        array[row, colom] = matrixValue;
        matrixValue++;
        if (row <= colom + 1 && (row + colom) < (array.GetLength(1) - 1))
        {
            colom++;
        }
        else if (row < colom && (row + colom) >= (array.GetLength(0) - 1))
        {
            row++;
        }
        else if (row >= colom && (row + colom) > (array.GetLength(1) - 1))
        {
            colom--;
        }
        else row--;
    }
    string[,] outputMatrix = new string[array.GetLength(0), array.GetLength(1)];
    {
        for (int i = 0; i < M; ++i)
        {
            for (int j = 0; j < N; ++j)
            {
                outputMatrix[i, j] = array[i, j].ToString();
                if (outputMatrix[i, j].Length < 2)
                {
                    outputMatrix[i, j] = "0" + outputMatrix[i, j];
                }
                Console.Write($"{outputMatrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
else Console.WriteLine("Ошибка вводимых данных");


