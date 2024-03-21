/*.Develop a c# program to implement stack with push and pop operations[Hint:Use class ,get/set 
properties, methods for push and pop and main method*/
using System;
class Stack
{
    int[] arr;
    int top;
    public Stack()
    {
        arr=new int[10];
        top=-1;
    }
    public void Push(int ele)
    {
        if(top==arr.Length-1)
        {
            Console.WriteLine("stack overflow");
            return;
        }
        arr[++top]=ele;
    }
    public void Pop()
    {
        if(top==-1)
        {
            Console.WriteLine("stack underflow");
            return;
        }
        Console.WriteLine("popped element is "+arr[top--]);
    }
    static void Main()
    {
        Stack s=new Stack();
        s.Push(10);
        s.Push(20);
        s.Push(30);
        s.Pop();
        s.Pop();
        s.Pop();
        s.Pop();
    }
}