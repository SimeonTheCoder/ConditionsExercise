using System;

class NumberInRange
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        if(number != 0 && number >= -100 && number <= 100)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}