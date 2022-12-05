// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//

//Console.WriteLine( "ders 1");
//string str = "hello world"; 
//char[] arr = str.ToCharArray(); /
//Console.WriteLine(firstRepeating(arr));

//

//int[] eded = { 2, 4 };
//char az = '+';
//var array = new int[] { 4, 3 };
//int result = Sum(1, az);
//Console.WriteLine(result);

//

//Console.WriteLine(ders 3);
//Console.WriteLine(Reverse("hello guys"));
//char az = ('+'); 

//

//Find('I');
//Console.WriteLine();
//Console.WriteLine("Ders 4");

//

//string[] array1 = { "Alik", "salam", "men", "dunya", "insan" };
//string[] arrayN = { "WOrld", "men", "alik", "Dunya", "kod" };
//FindTwins(array1, arrayN);
//Console.WriteLine("Ders 5");

#region 1.
//static char firstRepeating(char[] str)
//{
//    HashSet<char> h = new HashSet<char>();
//    for (int i = 0; i <= str.Length - 1; i++)
//    {
//        char c = str[i];
//        if (h.Contains(c))
//        {
//            return c;
//        }
//        else
//        {
//            h.Add(c);
//        }
//    }
//    return '\0';
//}

#endregion

#region 2. 
//static int Sum(int a, int b, char az = '-')
//{
//    return a + az + b;
//}
#endregion

#region 3. 
//static string Reverse(string Input)
//{

//    // Srt cevririk chara
//    char[] charArray = Input.ToCharArray();

//    // ??
//    string reversedString = String.Empty;

//    // sagdan sola 
//    for (int i = charArray.Length - 1; i > -1; i--)
//    {

//        // char arrayini sagdan sola cevirmek
//        reversedString += charArray[i];
//    }

//    // Return edib maine qaytarmaq
//    return reversedString;
//}
#endregion

#region ders 4
//static void Find(char x) 
//{


//    string[] countries = { "England", "Finland", "Iceland", "Ireland" };


//    foreach (string item in countries)
//    {
//        if (item.StartsWith(x))
//        {


//            Console.WriteLine(item);

//        }
//    }

//}
#endregion

#region ders 5
//static void FindTwins(string[] array1, string[] array2)
//{

//    if (array1.Length > 0 && array2.Length > 0)
//    {
//        for (int i = 0; i < array1.Length; i++)
//        {
//            for (int j = 0; j < array2.Length; j++)
//            {
//                if (array1[i].ToLower() == array2[j].ToLower())
//                {

//                    Console.WriteLine(array1[i]);

//                }
//            }
//        }
//    }

//}
#endregion
