using System;

namespace assignment_3
{
    internal class program
    {
        static void Main(string[] args)
        {

            #region Q1
            //int x;
            //Console.WriteLine("enter your number: ");
            //x= Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //if (x%3==0 && x%4==0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else { Console.WriteLine("no"); } 
            #endregion

            #region Q2
            //int x;
            //Console.WriteLine("enter your number: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //if(x==0)
            //{
            //    Console.WriteLine("zero");
            //}
            //else if(x>0)
            //{
            //    Console.WriteLine("positive");
            //}
            //else

            //{
            //     Console.WriteLine("negative");
            //} 
            #endregion

            #region Q3
            //int x,y, z;
            //Console.WriteLine("enter your first number: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter your second number: ");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter your third number: ");
            //z = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //int max = x;
            //int min = y;
            //if(y>max)
            //{
            //    max = y;
            //    Console.WriteLine($"max is {max}");
            //}
            //else if (z> max)
            //{
            //    max = z;
            //    Console.WriteLine($"max is {max}");
            //}
            //else
            //{
            //    Console.WriteLine($"max is {max}");
            //}
            //if (x < min)
            //{
            //    min = x;
            //    Console.WriteLine($"min is {min}");
            //}
            //else if (z < min)
            //{
            //    min = z;
            //    Console.WriteLine($"min is {min}");
            //}
            //else
            //{
            //    Console.WriteLine($"min is {min}");
            //} 
            #endregion

            #region Q4
            //int x;
            //Console.WriteLine("enter your number: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //if (x % 2 == 0)
            //{ Console.WriteLine("x is even"); }
            //else
            //{ Console.WriteLine("x is odd");

            //} 
            #endregion

            #region Q5
            //char x;
            //Console.WriteLine("enter your character: ");
            //x = Convert.ToChar(Console.ReadLine().ToLower());
            //Console.Clear();
            //switch (x)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;
            //} 
            #endregion

            #region Q6
            //int x;
            //Console.WriteLine("enter your number");
            //x= Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //for (int i = 1; i <= x; i++)
            //{
            //    Console.Write($"{i}, ");
            //} 
            #endregion

            int x;
            Console.WriteLine("enter your number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for(int i=1;i<=12;i++)
            {
                int result = x * i;
                Console.Write($"{result},");
            }


        }
    }
}