using System;

namespace assignment_3
{
    internal class program
    {
        static void Main(string[] args)
        {

            int x;
            Console.WriteLine("enter your number: ");
            x= Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (x%3==0 && x%4==0)
            {
                Console.WriteLine("yes");
            }
            else { Console.WriteLine("no"); }
        }
    }
}