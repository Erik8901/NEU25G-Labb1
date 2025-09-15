//Skapa en konsollapplikation som ber användaren mata in en text (string) i konsollen.
//Den inmatade strängen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
//och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
//siffror förekommer där emellan. 

//ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
//ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
//t.ex 95a9 är inte heller ett korrekt tal.

//För varje sådan delsträng som matchar kriteriet ovan ska programmet skriva ut en
//rad med hela strängen, men där delsträngen är markerad i en annan färg.
//Exempel output för input ”29535123p48723487597645723645”:

//Programmet ska också addera ihop alla tal den hittat enligt ovan och skriva ut det
//sist i programmet. Gör gärna en tom rad emellan för att skilja från output ovan.
//Exempel output för input ”29535123p48723487597645723645”:
//Total = 5836428677242

// test string: 29535123p48723487597645723645”


//Console.Write("Enter a string with numbers and letters");






using System;
using System.Runtime.Serialization.Formatters;
using System.Text.RegularExpressions;

 //2392
string numbers = "29535123";
ulong total = 0;
char tw = '2';
char five = '5';
//string[] arr= new string[str.Length];

//int firstIndex = 0;
//int length = str.Length;

//int i = 0;

//int length = str.Length;
//bool match = false;

//foreach (char c in str)
//{
//    if (char.IsDigit(c))
//    {
//        //Console.ForegroundColor = ConsoleColor.Green;
//        //Console.WriteLine(c);
//        //Console.ResetColor();
//        numbers += c;
//    }
//}
//Console.WriteLine(numbers);
//string[] parts = Regex.Split(str, @"\D+");

//foreach (string part in parts)
//{
//    if(!string.IsNullOrEmpty(part))
//    {
//        Console.WriteLine(parts);
//    }
//}
Console.Write("Enter a string with numbers and letters: ");
string name = Console.ReadLine();
//Console.WriteLine("Hej " + name);
//string input = "44sugar1100";
string pattern = "[a-zA-Z]+";            // Split on any group of letters
//string str = "29535123p48723487597645723645";
string[] substrings = Regex.Split(name, pattern);
//string sub = string.Empty;
//string sub1 = string.Empty;
foreach (string match in substrings)
{
    // Console.WriteLine("'{0}'", match);

  //  sub1 = match;
   //onsole.WriteLine(match);


    for (int i = 0; i < match.Length; i++)
    {

        for (int j = i + 1; j < match.Length; j++)
        {
    
            if (match[i] == match[j])
            {
             if(match.Length > j - i)
                {
                    string res = match.Substring(i, j - i + 1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(res);
                    Console.ResetColor();
                    ulong vOut = Convert.ToUInt64(res);
                    total += vOut;
                    break;
                }
            }
        }
    }

}
Console.WriteLine($"The total sum is: {total}");

//int length = numbers.Length;
//for (int i = 0; i < length; i++)
//{


//        char start = numbers[i];


//        for (int j = i + 2; j < length; j++)
//        {

//            if (numbers[j] == start)
//            {
//             // Console.WriteLine(str[j]);


//            if (numbers.Length > i + j)
//            {
//                //string sub = numbers.Substring(i, j + 1);
//                //Console.WriteLine(sub);
//            }

//        }
//        }



//        //for (int j = i; j < numbers.Length; j++)
//        //{

//        //    // Console.WriteLine($"j{str[j]}");
//        //    if (numbers[i] == numbers[j])
//        //    {

//        //        string substring = numbers.Substring(i, j + 1 - i);
//        //        // Console.WriteLine($"sub {substring}");
//        //        Console.ForegroundColor = ConsoleColor.Green;
//        //        Console.WriteLine(substring);
//        //        Console.ResetColor();

//        //    }


//   //}


//}



















//for (int i = 0; i < str.Length; i++)
//    {
//    if (char.IsDigit(str[i]))
//    {
//        numbers += str[i];
//    }
//}






//    //Console.WriteLine($"'{two}' at index {i}");
//    //    //string t = str.Substring(0, 7);
//    //    //string t2 = str.Substring(12, 13);
//    //    //Console.WriteLine(t);
//    //    //Console.WriteLine(t2);

//  int j = i;

//    if (numbers[i] == two )
//    {
//       // Console.WriteLine($"'{two}' at index {i}");

//        //string t1 = str.Substring(0, 6);
//        //string t2 = str.Substring(12, 13);
//        //Console.WriteLine(t1);
//        //Console.WriteLine(t2);
//        //if (str.Length > i + j)
//        //{

//        //    string substring = str.Substring(i, j+1);

//        //  Console.WriteLine(substring);
//        //    //string numbers = Regex.Replace(substring, "[^.0-9\\s]", "");
//        //    //ulong uLongNumbers = ulong.Parse(numbers);
//        //    // total += uLongNumbers;


//        //}
//        //int length = i + j;

//    }

//    //int length = i + j;


//    //// Console.WriteLine($"i {str[i]}");
//    for (int j = i; j < str.Length; j++)
//{

//        // Console.WriteLine($"j{str[j]}");
//        if (str[i] == str[j])
//        {

//            string substring = str.Substring(i, j + 1 - i);
//           // Console.WriteLine($"sub {substring}");
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine(substring);
//            Console.ResetColor();

//        }

//        }
//        //    //Console.WriteLine($"'{two}' at index {i}");
//        //    //    //string t = str.Substring(0, 7);
//        //    //    //string t2 = str.Substring(12, 13);
//        //    //    //Console.WriteLine(t);
//        //    //    //Console.WriteLine(t2);
//    }







