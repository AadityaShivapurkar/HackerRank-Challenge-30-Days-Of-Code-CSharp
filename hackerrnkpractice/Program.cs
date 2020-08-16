//Day 0: Hello, World.

/*using System;
using System.Collections.Generic;
using System.IO;
namespace HelloWorld
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, World.");
            Console.WriteLine(userName);
        }
    }
}*/

//Day 1: Data Types

/*
using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
    }
}*/

//Day 2: Operators

/*using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Security.Cryptography.X509Certificates;

class Solution
{

    // Complete the solve function below.
    static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double tip = meal_cost * (Convert.ToDouble(tip_percent) / 100);
        double tax = meal_cost * (Convert.ToDouble(tax_percent) / 100);
        double totalCost = Math.Round(meal_cost + tip + tax);
        Console.WriteLine(totalCost);
    }

    static void Main(string[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);
    }
}*/

//Day 3: Intro to Conditional Statements

/*using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{



    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        if ((N % 2) == 1 && N <= 3)
        {
            Console.WriteLine("Weird");
        }
        else
        {
            if ((N >= 2) && (N <= 5))
            {

                if ((N % 2) == 1)
                {
                    Console.WriteLine("Weird");
                }
                else
                {
                    Console.WriteLine("Not Weird");
                }
            }
            else
            {
                if ((N >= 6) && (N <= 20))
                {
                    Console.WriteLine("Weird");
                }
                else
                {
                    if (N > 20)
                    {

                        if ((N % 2) == 1)
                        {
                            Console.WriteLine("Weird");
                        }
                        else
                        {
                            Console.WriteLine("Not Weird");
                        }
                    }
                }
            }
        }

    }
}
*/

//Day 4: Class vs.Instance

/*using System;
using System.Collections.Generic;
using System.IO;

class Person
{
    public int age;
    public Person(int initialAge)
    {
        // Add some more code to run some checks on initialAge
        if (initialAge < 0)
        {
            this.age = 0;
            Console.WriteLine("Age is not valid, setting age to 0.");
        }
        else
        {
            this.age = initialAge;
        }
    }
    public void amIOld()
    {
        // Do some computations in here and print out the correct statement to the console
        if (this.age < 13)
        {
            Console.WriteLine("You are young.");
        }
        else
        {
            if (this.age >= 13 && this.age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }

        }
    }

    public void yearPasses()
    {
        this.age++;
    }

    static void Main(String[] args)
    {
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int age = int.Parse(Console.In.ReadLine());
            Person p = new Person(age);
            p.amIOld();
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses();
            }
            p.amIOld();
            Console.WriteLine();
        }
    }
}
*/

//Day 5: Loops

/*using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{



    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < 11; i++)
        {
            int mulx = n * i;
            Console.WriteLine(n + " x " + i + " = " + mulx);
        }
    }
}*/

//Day 6: Let's Review

/*using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        string[] strings = new string[num];
        int p = 0;
        while (p < num)
        {
            strings[p] = Console.ReadLine();
            p++;
        }
        foreach (string a in strings)
        {
            string evens = "";
            string odds = "";
            bool isEven = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (isEven) evens += a[i];
                else odds += a[i];

                isEven = !isEven;
            }
            Console.WriteLine($"{evens} {odds}");
        }

    }
}*/

//Day 7: Arrays

/*using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr1 = Array.ConvertAll(arr_temp, Int32.Parse);
        int length = n;
        Array.Reverse(arr1);
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr1[j]} ");
        }

    }

}*/

//Day 8: Dictionaries and Maps

/*using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
class Solution
{
    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> phoneBook = new Dictionary<string, int>(N);
        for (int i = 0; i < N; i++)
        {
            string[] temp = Console.ReadLine().Split(' ');
            if (temp[1].Length == 8)
            {
                phoneBook.Add(temp[0], Convert.ToInt32(temp[1]));
            }
        }
        string nameToSearch = "";
        while ((nameToSearch = Console.ReadLine()) != null)
        {
            int flagFound = 0;
            if (nameToSearch != "")
            {
                if (phoneBook.ContainsKey(nameToSearch))
                {
                    flagFound = 1;
                }
            }
            if (flagFound == 1)
            {
                Console.WriteLine(nameToSearch + "=" + phoneBook[nameToSearch]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}*/

//Day 9: Recursion 3

/*using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the factorial function below.
    static int factorial(int n)
    {


    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int result = factorial(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}*/



