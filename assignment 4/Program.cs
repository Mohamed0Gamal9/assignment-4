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

            #region Q7
            //int x;
            //Console.WriteLine("enter your number");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //for(int i=1;i<=12;i++)
            //{
            //    int result = x * i;
            //    Console.Write($"{result},");
            //} 
            #endregion

            #region Q8
            //int x;
            //Console.WriteLine("enter your number");
            //x= Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //for (int i = 1; i <= x; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i} ,");
            //    }

            //} 
            #endregion

            #region Q9
            //int x,y;
            //Console.WriteLine("enter your first number: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter your second number: ");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //    int result=1;
            //for (int i = 1; i <= y; i++)
            //{
            //    result*=x;
            //}
            //Console.WriteLine($"{result}"); 
            #endregion

            #region Q10
            //int a, b, c, d, e;
            //Console.WriteLine("enter your first subject mark:  ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter your second subject mark:  ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter your third subject mark:  ");
            //c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter your fourth subject mark:  ");
            //d = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter your fifth subject mark:  ");
            //e = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //int total = a + b + c + d + e;
            //Console.WriteLine(total);
            //int average = total / 5;
            //Console.WriteLine(average);
            //float precentage=((float)total/500) * 100;
            //Console.WriteLine(precentage); 
            #endregion

            #region Q11
            //Console.Write("Enter month number: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("This month has 31 days");
            //        break;

            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("This month has 30 days");
            //        break;

            //    case 2:
            //        Console.WriteLine("This month has 28 or 29 days ");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid month number. Please enter a number from 1 to 12");
            //        break;
            //} 
            #endregion

            #region Q12
            //int x, y;
            //Console.WriteLine("Enter your first number: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your second number: ");
            //y = Convert.ToInt32(Console.ReadLine());
            //char b;
            //Console.WriteLine("Enter your operator (+, -, *, /): ");
            //b = Convert.ToChar(Console.ReadLine());
            //Console.Clear();
            //switch(char.ToLower(b))
            //{
            //    case '+':
            //        Console.WriteLine($"The result of {x} + {y} is: {x + y}");
            //        break;
            //        case '-':
            //        Console.WriteLine($"The result of {x} - {y} is: {x - y}");
            //        break;
            //        case '*':
            //        Console.WriteLine($"The result of {x} * {y} is: {x * y}");
            //        break;
            //        case '/':
            //        Console.WriteLine($"The result of {x} / {y} is: {x / y}");
            //        break;
            //        default:
            //        Console.WriteLine("Invalid operator. Please enter one of the following: +, -, *, /");
            //        break;

            //} 
            #endregion

            string x;
            Console.WriteLine("enter your word: ");
            x = Console.ReadLine();
            Console.Clear();
            for (int i = x.Length-1; i >= 0; i--)
            {
                Console.WriteLine(x[i]);
            }


        }
    }
}