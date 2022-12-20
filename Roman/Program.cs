using System.Collections.Generic;

string GetRoman(int num)
{
    string roman = "";
    // Create Dictionary Object to store Roman Numbers
    Dictionary<string, int> romanNums = new Dictionary<string, int>();

    romanNums.Add("M", 10000);
    romanNums.Add("CM", 900);
    romanNums.Add("D", 500);
    romanNums.Add("CD", 400);
    romanNums.Add("C", 100);
    romanNums.Add("XC", 90);
    romanNums.Add("L", 50);
    romanNums.Add("XL", 40);
    romanNums.Add("X", 10);
    romanNums.Add("IX", 9);
    romanNums.Add("V", 5);
    romanNums.Add("IV", 4);
    romanNums.Add("I", 1);

    foreach (KeyValuePair<string, int> item in romanNums)
        {
            while(num >= item.Value)
        {
            roman += item.Key;
            num -= item.Value;
        }
        

    }

    return roman;
}

Console.WriteLine(GetRoman(7));