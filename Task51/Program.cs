// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д

Console.WriteLine("Введите размерность массива m x n: ");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;

int[,] matrix = new int [m, n];
for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next( 0, 11);
        Console.Write(matrix[i, j] + " ");
        if (i == j)
        {
            sum = sum + matrix[i, j];
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine(sum);