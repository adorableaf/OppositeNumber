using System;


namespace OppositeNumber
{
    /*
     * Very simple, given an integer or a floating-point number, find its opposite. 
     * 
     * Examples:
     * 
     * 1: -1
     * 14: -14
     * -34: 34
     * 
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, чтобы получить его противоположность:");

            double Number = double.Parse(Console.ReadLine());

            Number = -Number;

            Console.WriteLine(Number);
        }
    }
}
