//Develop C# program to demonstrate division by zero and index out of range exceptions
using System;
class ExceptionDemo
{
    static void Main()
    {
        DivisionByZero();
        IndexOutOfRange();

    }
    static void DivisionByZero()
    {
        try
        {
            Console.WriteLine("enter two numbers");
            int op1=Convert.ToInt32(Console.ReadLine());
            int op2=Convert.ToInt32(Console.ReadLine());

            int result=op1/op2;

            Console.WriteLine("result is "+result);
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine("division by zero is not possible");
        }
    }
    static void IndexOutOfRange()
    {
        try
        {
            Console.WriteLine("enter a string");
            string str=Console.ReadLine();

            Console.WriteLine("enter index");
            int index=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("character at index "+index+" is "+str[index]);
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("index out of range");
        }
    }
}
