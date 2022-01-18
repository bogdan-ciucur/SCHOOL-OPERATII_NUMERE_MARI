using System;
using System.Collections;

class GFG {

    static bool isSmaller(string str1, string str2)
    {
        int n1 = str1.Length, n2 = str2.Length;
        if (n1 < n2)
            return true;
        if (n2 < n1)
            return false;

        for (int i = 0; i < n1; i++)
            if (str1[i] < str2[i])
                return true;
            else if (str1[i] > str2[i])
                return false;

        return false;
    }

    static string findDiff(string str1, string str2)
    {
        if (isSmaller(str1, str2)) {
            string t = str1;
            str1 = str2;
            str2 = t;
        }

        string str = "";

        int n1 = str1.Length, n2 = str2.Length;

        char[] ch1 = str1.ToCharArray();
        Array.Reverse(ch1);
        str1 = new string(ch1);
        char[] ch2 = str2.ToCharArray();
        Array.Reverse(ch2);
        str2 = new string(ch2);

        int carry = 0;

        for (int i = 0; i < n2; i++) {
            int sub = ((int)(str1[i] - '0')
                       - (int)(str2[i] - '0') - carry);

            if (sub < 0) {
                sub = sub + 10;
                carry = 1;
            }
            else
                carry = 0;

            str += (char)(sub + '0');
        }

        for (int i = n2; i < n1; i++) {
            int sub = ((int)(str1[i] - '0') - carry);

            if (sub < 0) {
                sub = sub + 10;
                carry = 1;
            }
            else
                carry = 0;

            str += (char)(sub + '0');
        }

        char[] ch3 = str.ToCharArray();
        Array.Reverse(ch3);
        return new string(ch3);
    }

    public static void Main()
    {

        string s1, s2;

        Console.WriteLine("introduceti val primului nr:");
        s1 = Console.ReadLine();

        Console.WriteLine("introduceti val primului nr:");
        s2 = Console.ReadLine();


        

        Console.WriteLine(findDiff(s1, s2));
        Console.WriteLine("0 inseamna -");


        
    }
}