// 52.Задайте двумерный массив из целых чисел. 
//Найдите среднее арифмитическое элементов в каждом столбце
//(складываем все элементы столбца а потом делим на количество строк)

int[,] Create2DMassiv(int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-99, 99);
        }
    }
    return matrix;
}

int  GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Print2DMassiv(int [,] massiv)
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

void FindArithmeticMeanColumns(int [,] massiv)
{
    for(int i = 0; i < massiv.GetLength(1); i++)
    {
         int numberOfColumns =0;
         double arithmeticMean = 0;
        for(int j = 0; j < massiv.GetLength(0); j++)
        {
            numberOfColumns = j;
          arithmeticMean += massiv[j,i];
        }
        arithmeticMean /= (numberOfColumns + 1);
        Console.WriteLine($"Среднее арифмитическое колонки {i + 1} = {arithmeticMean}");
    }

}

int rows = GetInput("Введите количество строк массива: ");
int columns = GetInput("Введите количество столбцов массива: ");
int [,] massiv = Create2DMassiv(rows,columns);
Print2DMassiv(massiv);
FindArithmeticMeanColumns(massiv);