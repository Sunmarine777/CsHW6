//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

using System;
public class Test
{
    public static bool Palindrome(string text)
    {
       if(string.IsNullOrWhiteSpace(text))
          return false;
  
        text = text.ToLower();
        for(int i = 0; i < text.Length / 2; i++)
        {
          if(text[i] != text[text.Length - 1 - i])
            return false;
        }
        return true;
    }
    
  public static void Main()
    {
      Console.WriteLine("Enter some text: ");
        var text = Console.ReadLine();
        var check = Palindrome(text);

        Console.WriteLine(text + " is " + (check ? "" : "not ") + "Palindrome.");
    }
}
