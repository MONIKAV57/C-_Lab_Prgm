//1.Develop a c# program to simulate simple arithmetic calculator for Addition, Subtraction,
//Multiplication, Division and Mod operations. Read the operator and operands through console
using System;
class calculator
{
    static void Main()
    {
        Console.WriteLine("enter operator (+  /  * % )");
        char op=Console.ReadLine()[0];

        Console.WriteLine("enter two numbers");
        double op1=Convert.ToDouble(Console.ReadLine());
        double op2=Convert.ToDouble(Console.ReadLine());

        double result=0;

        switch(op)
        {
            case '+': 
            result=op1+op2;
            break;

            case '-':
             result=op1-op2;
            break;

            case '*':
            result=op1*op2;
            break;

            case '/':
             result=op1/op2;
            if(op2==0)
            {
                Console.WriteLine("division by zero is not possible");
                return;
            }
            break;

            case '%': 
            result=op1%op2;
            if(op2==0)
            {
                Console.WriteLine("division by zero is not possible");
                return;
            }
            break;
            
            default: Console.WriteLine("invalid operator");
            break;
        }
        Console.WriteLine("result is "+result);
    } 
}
