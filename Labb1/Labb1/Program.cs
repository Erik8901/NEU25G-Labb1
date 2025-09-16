// test string: 29535123p48723487597645723645”

using System.Text.RegularExpressions;


Console.Write("Enter a string with numbers and letters: ");
string str = Console.ReadLine();

string pattern = "[a-zA-Z]+";          
string[] substrings = Regex.Split(str, pattern);
ulong total = 0;

foreach (string numbers in substrings)
{
   for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
    
            if (numbers[i] == numbers[j])
            {
             
                if(numbers.Length > j - i)
                {
                    string res = numbers.Substring(i, j - i + 1);
                    
                    int index = str.IndexOf(res);
                    
                    if (index >= 0)
                    {
                        Console.Write(str.Substring(0, index));
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(res);
                        Console.ResetColor();

                        Console.WriteLine(str.Substring(index + res.Length));

                    } else
                    {
                        Console.WriteLine(str);
                    }
                    ulong Utotal = Convert.ToUInt64(res);
                    total += Utotal;
                    break;
                }
            } 
        }
    }
}

Console.WriteLine($"The total sum is: {total}");