using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZAR3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TARGIL 1");
            while (true)
            {
                 Console.WriteLine("please enter a number");
                 int num1 = Convert.ToInt32(Console.ReadLine());
                 if (num1 == 2 || num1 == 3 || num1 == 5 || num1 == 7 || num1 == 9)
                 {
                     Console.WriteLine("prime!");
                     break;
                 }
                 if (num1 % 2 == 0 || num1 % 3 == 0 || num1 % 5 == 0 || num1 % 7 == 0 || num1 % 9 == 0)
                 {
                     Console.WriteLine("not prime!");
                     continue;
                 }
                 else
                 {
                     Console.WriteLine("prime!");
                     break;
                 }
             }
             Console.WriteLine("_____________________________________________________________");
                Console.WriteLine("TARGIL 2");
                int class_100 = 0;
                int class_30 = 0;
                int class_10 = 0;
                Console.WriteLine("please enter number of students");
                int students2 = Convert.ToInt32(Console.ReadLine());
                while (students2 >= 10)
                {
                    if (students2 >= 100)
                    {
                        class_100++;
                        students2 -= 100;
                    }
                    else if (students2 >= 30 && students2 < 100)
                    {
                        class_30++;
                        students2 -= 30;
                    }
                    else if (students2 >= 10 && students2 < 30)
                    {
                        class_10++;
                        students2 -= 10;
                    }
                    else if (students2 < 10)
                {
                    break;
                }
                }
                Console.WriteLine("100: " + class_100);
                Console.WriteLine("30: " + class_30);
                Console.WriteLine("10: " + class_10);
                if (students2 < 10)
                {
                    Console.WriteLine(students2 + " students go home");
                }
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("TARGIL 3");
            int number3 = 0;
            do
            {
                Console.WriteLine("Please enter number of lines:");
            }
            while (int.TryParse(Console.ReadLine(), out number3) == false);

            Console.WriteLine();

            // 1
            // 12
            // 123
            // 1234
            for (int line_number = 1; line_number <= number3; line_number++)
            {
                for (int row = 1; row <= line_number; row++)
                {
                    Console.Write(row);
                }
                Console.WriteLine();
            }

            // 123
            // 12
            // 1
            for (int line_number = number3 - 1; line_number >= 1; line_number--)
            {
                for (int row = 1; row <= line_number; row++)
                {
                    Console.Write(row);
                }
                Console.WriteLine();
            }
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("TARGIL 4");
            int number = 0;
            do
            {
                Console.WriteLine("Please enter number of lines:");
            }
            while (int.TryParse(Console.ReadLine(), out number) == false);

            Console.WriteLine();

            // 4 lines
            //    *
            //   ***
            //  *****
            // *******
            int stars = 1;
            int spaces = number - 1;
            for (int line_number = 1; line_number <= number; line_number++)
            {
                // spaces
                for (int row = 1; row <= spaces; row++)
                {
                    Console.Write(' ');
                }

                // stars *
                for (int row = 1; row <= stars; row++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();

                stars = stars + 2;
                spaces--;
            }

        }
    }
    }
