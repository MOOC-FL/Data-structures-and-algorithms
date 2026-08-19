using System;
using System.Collections.Generic;

public class Program()
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello, World , This is Data Structure");
        List<int> num = new List<int>();
        num = [0, 5, 6, 9, 8, 10];
        //List<int> num1 = num;
        //Array int num1 = ['1', '2'];
        Console.WriteLine("The Cont Of even numbers is : ");
        Console.WriteLine(CountEven(num));
        Console.WriteLine("And the Even Numbers is : ");
        PrintEven(num);
    }
    public static int CountEven(List <int> numbers)
    {
        int result = 0;
        //List numbers1 = numbers;
        foreach (int x in numbers)
        {
            if (x % 2 == 0)
            {
                result++;
            }
        }
        return result;
    }
    public static void PrintEven(List<int> numbers)
    {
        foreach (int x in numbers)
        {
            if (x % 2 == 0)
            {
                Console.Write(x + " ");
            }
        }
    }
}