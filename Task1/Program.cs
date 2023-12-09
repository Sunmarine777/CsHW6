//Задача 1: Задайте двумерный массив символов (тип char [,]).
//Создать строку из символов этого массива.

using System.Data;

const int m = 5;
const int n = 5;
char[,] chars = new char[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
      for (int j = 0; j < n; j++)
      {
      chars[i,j] = (char)('a' + rand.Next(0,26));
      Console.Write(chars[i,j]+" ");
      }
Console.WriteLine();
}
Console.WriteLine("----------------");
for (int i = 0; i < m; i++)
{
      for (int j = 0; j < n; j++)
      {
            Console.Write(Convert.ToString(chars[i,j]+" "));
      }
}
Console.ReadKey(true);