

//. Задача 54.
/*

using System;
 
namespace TestAppl
{
    class Program
    {
        static void Main(String[] args)
        {
            var a = new Int32[4][];
 
            var random = new Random();
            for (var i = 0; i < a.Length; i++)
            {
                a[i] = new Int32[5];
                for (var j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = random.Next(100);
                }
            }
            Print(a);
 
            GetStatistic(a);
 
            Console.WriteLine("---");
            //сортируем
            foreach (Int32[] t in a)
                Array.Sort(t, ((i, i1) => i1.CompareTo(i)));
            Print(a);
            GetStatistic(a);
            Console.Read();
        }
 
        static void Print(Int32[][] a)
        {
            for (var i = 0; i < a.Length; i++, Console.WriteLine())
                for (var j = 0; j < a[i].Length; j++)
                {
                    Console.Write("{0,4}", a[i][j]);
                }
        }
 
        static void GetStatistic(Int32[][] a)
        {
            Console.WriteLine("===== Statistic ====");
            Int32
                max = a[0][0],
                min = a[0][0],
                maxI = 0,
                maxJ = 0,
                minI = 0,
                minJ = 0;
 
            for (var i = 0; i < a.Length; i++)
                for (var j = 0; j < a[i].Length; j++)
                {
                    if (max < a[i][j])
                    {
                        max = a[i][j];
                        maxI = i;
                        maxJ = j;
                    }
                    if (min > a[i][j])
                    {
                        min = a[i][j];
                        minI = i;
                        minJ = j;
                    }
                }
            Console.WriteLine($"max: {max}; min: {min}; maxI: {maxI}; maxJ: {maxJ}; minI: {minI}; minJ: {minJ}");
        }
    }
}

*/


//. Задача 56.
/*

const int n = 5;
const int m = 5;

const int max = 10;

var rand = new Random();

var array = new int[n][];
for (int i = 0; i < n; i++)
{
    array[i] = new int[m];
    for (int j = 0; j < m; j++)
        array[i][j] = rand.Next(max + 1);
}

Console.WriteLine("Массив = ");
foreach (var row in array)
{
    foreach (var value in row)
        Console.Write($"{value,4}");
    Console.WriteLine();
}

var min = array.Min(row => row.Max());
Console.WriteLine($"Минимальный элемент из максимальных каждой строки = {min}");
*/



//. Задача 62. 
/*

int N = 3, M = 3;
            int[,] A = new int[N, M];
 
            int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = M;
 
            for (int i = 0; i < A.Length; i++)
            {
                A[col, row] = i + 1;
                if (--gran == 0)
                {
                    gran = M * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                col += dx;
                row += dy;
            }
 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
 
            Console.ReadKey();
*/
