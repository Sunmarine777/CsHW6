//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.


using System.Data;

int m = 10;
char[] chars = new char[m];
Random rand = new Random();


for (int i = 0; i < m; i++)
{
      chars[i] = (char)('a' + rand.Next(0,26));

      if (i % 2 == 0)
      chars[i] = char.ToUpper(chars[i]);
      

      else
      chars[i] = char.ToLower(chars[i]);


      Console.Write(chars[i]+" ");     
}

Console.WriteLine();
for (int i = 0; i < m; i++)
{

      Console.Write(Convert.ToString(char.ToLower(chars[i])+" "));

}
Console.ReadKey(true);