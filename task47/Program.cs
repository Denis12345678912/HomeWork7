// 47.Задайте двумерный массив размером m*n,  заполненный случайными вещественными числами. (с плавающей точкой)
double[,] Create2DMassiv(int rows, int columns)
{
    double [,] matrix = new double [rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().NextDouble() * 100;
          matrix[i,j] =  Convert.ToDouble( matrix[i,j].ToString("0.00"));
        }
    }
    return matrix;
}

int  GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Print2DMassiv(double [,] massiv)
{
 for(int i = 0; i < massiv.GetLength(0); i++)
    {
        for(int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int rows = GetInput("Введите количество строк массива: ");
int columns = GetInput("Введите количество столбцов массива: ");
double [,] massiv = Create2DMassiv(rows,columns);
Print2DMassiv(massiv);