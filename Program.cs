/* Задача 52.
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
double [,] RandomNumbersArray(int a, int b)
{
 double[,] Num = new double[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
        Num [i,j] = Math.Round(new Random().NextDouble()*(9-(1))+(1), 0); // Случайное целое число double от 0 до 9 вкл-но.
        }   
    }
    return Num;
}

double [] ArrayColsAvg(double[,] aaa)
{
    int x = aaa.GetLength(0);
    int y = aaa.GetLength(1);
    double [] Avg = new double [y];
    double [] sum = new double[y];
    for (int j = 0; j < y; j++)
    {
        sum[j] = 0;
        for (int i = 0; i < x; i++)
        {
          sum[j] = aaa[i,j] + sum[j];
          if (i == x-1) Avg [j] =  Math.Round((sum[j] / x), 2);
        }
    }
return Avg;
}

void Print2Dim(double [,] aaa)
{
System.Console.WriteLine();
int x = aaa.GetLength(0);
int y = aaa.GetLength(1);
System.Console.WriteLine($"Создан массив случайных целых чисел размером {x} строк и {y} столбцов:");
System.Console.WriteLine();
for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
            System.Console.Write("{0}\t", aaa[i, j]);
        System.Console.WriteLine("");
    }
System.Console.WriteLine();
System.Console.WriteLine();

}

void PrintLinear(double [] bbb)
{
System.Console.WriteLine();
System.Console.WriteLine("Среднее арифметическое всех элементов каждого столбца:");
Console.WriteLine(String.Join("; ", bbb));
System.Console.WriteLine();
}



Console.WriteLine();
Console.Write("Введите количество строк массива случайных целых чисел: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество столбцов массива случайных целых чисел: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
double [,] qqq = RandomNumbersArray(m, n);
double [] rrr = ArrayColsAvg(qqq);
Print2Dim(qqq);
PrintLinear(rrr);