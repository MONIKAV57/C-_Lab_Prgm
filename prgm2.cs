//.Develop c# program to print Armstrong Number between 1 to 1000
using System;
class Armstrong
{
    static void Main()
    {
        for(int i=1;i<=1000;i++)
        {
            int num=i;
            int sum=0;
            while(num>0)
            {
                int rem=num%10;
                sum=sum+rem*rem*rem;
                num=num/10;
            }
            if(sum==i)
            {
                Console.WriteLine(i);
            }
        }
    }
}