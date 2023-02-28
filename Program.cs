// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] tab = new int[n, m];
void FillArray(int[,] con)
{
    for (int rows = 0; rows < con.GetLength(0); rows++)
    {
        for (int columns = 0; columns < con.GetLength(1); columns++)
        {
            con[rows, columns] = new Random().Next(1, 10);
            Console.Write($"{con[rows, columns],3}");
        }
        Console.WriteLine();
    }
}
void Number(int[,] con)
{
    double result = 0;
    double sum = 0;
    for (int columns = 0; columns < con.GetLength(1); columns++)
    {
        for (int rows = 0; rows < con.GetLength(0); rows++)
        { sum += con[rows, columns]; }
        Console.Write($"{result}");
        result = sum / con.GetLength(0);
    }
}
FillArray(tab);
Number(tab);
