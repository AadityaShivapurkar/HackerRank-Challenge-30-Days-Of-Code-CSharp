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

//Day 10: Binary Numbers

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
        int max = 0, cur = 0;

        while (n > 0)
        {
            cur = (n % 2) > 0 ? cur + 1 : 0;
            if (cur > max)
                max = cur;
            n = n >> 1;
        }

        Console.WriteLine(max);
    }


}*/

//Day 11: 2D Arrays
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
        int[][] arr = new int[6][];
        int r, c;
        int result = -2147483648;
        int sum;

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        for(r=0; r<=3; r++)
        {
            for(c=0; c<=3; c++)
            {
                sum = arr[r][c] + arr[r][c + 1] + arr[r][c + 2] + arr[r + 1][c + 1] + arr[r + 2][c] + arr[r + 2][c + 1] + arr[r + 2][c + 2];
                result = Math.Max(result, sum);
            }
        }
        Console.WriteLine(result);
    
    }
}*/

//Day 12: Inheritance

/*using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;

    /*    
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
// Write your constructor here
/* public Student(string firstName, string lastName, int id, int[] scores)
 {
     this.firstName = firstName;
     this.lastName = lastName;
     this.id = id;
     this.testScores = scores;
 }*/
/*    
*   Method Name: Calculate
*   Return: A character denoting the grade.
*/
// Write your method here
/*public string Calculate()
 {
     var average = testScores.Average();
     var res = IsWithin(average, 90, 100) ? "O" :
                 IsWithin(average, 80, 89) ? "E" :
                 IsWithin(average, 70, 79) ? "A" :
                 IsWithin(average, 50, 69) ? "P" :
                 IsWithin(average, 40, 54) ? "D" :
                 "T";
     return res;

 }

 private bool IsWithin(double value, int minimum, int maximum)
 {
     return value >= minimum && value <= maximum;
 }
}

class Solution
{
 static void Main()
 {
     string[] inputs = Console.ReadLine().Split();
     string firstName = inputs[0];
     string lastName = inputs[1];
     int id = Convert.ToInt32(inputs[2]);
     int numScores = Convert.ToInt32(Console.ReadLine());
     inputs = Console.ReadLine().Split();
     int[] scores = new int[numScores];
     for (int i = 0; i < numScores; i++)
     {
         scores[i] = Convert.ToInt32(inputs[i]);
     }

     Student s = new Student(firstName, lastName, id, scores);
     s.printPerson();
     Console.WriteLine("Grade: " + s.Calculate() + "\n");
 }
}*/

//Day 13: Abstract Classes

/*using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{

    protected String title;
    protected String author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();


}

//Write MyBook class
class MyBook : Book
{
    int price = 0;
    public MyBook(string title, string author, int price) : base(title, author)
    {
        this.price = price;
    }

    public override void display()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

class Solution
{
    static void Main(String[] args)
    {
        String title = Console.ReadLine();
        String author = Console.ReadLine();
        int price = Int32.Parse(Console.ReadLine());
        Book new_novel = new MyBook(title, author, price);
        new_novel.display();
    }
}*/

//Day 14: Scope

/*using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    // Add your code here
    public Difference(int[] elements)
    {
        this.elements = elements;
    }

    public void computeDifference()
    {
        Array.Sort(elements);
        int size = elements.Count();
        int min = elements[0];
        int max = elements[size - 1];
        maximumDifference = max - min;
    }

} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}*/

