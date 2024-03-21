//Develop a c# program to list all substrings in a given string [Hint:use of Substring() method]
using System;
class Substring
{
    static void Main()
    {
        Console.WriteLine("enter a string");
        string str=Console.ReadLine();
        for(int i=0;i<str.Length;i++)
        {
            for(int j=i+1;j<=str.Length;j++)
            {
                Console.WriteLine(str.Substring(i,j-i));
            }
        }
    }
}