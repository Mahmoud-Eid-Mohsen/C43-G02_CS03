using System.ComponentModel.Design;
using System.Transactions;

namespace Asignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Write a program that takes a number from the user then print yes
            // if that number can be divided by 3 and 4 otherwise print no
            Console.WriteLine("Enter number to check ");
            Console.Write("number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 3 == 0 && num % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            #endregion
            #region Q2
            //Write a program that allows the user to insert an integer then print negative
            //if it is negative number otherwise print positive.
            Console.WriteLine("Enter integer number to check ");
            Console.Write("number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 >= 0)
                Console.WriteLine("positive number");
            else
                Console.WriteLine("negative number");
            #endregion
            #region Q3
            //3- Write a program that takes 3 integers from the user then prints
            //the max element and the min element.
            Console.WriteLine("Enter integer 3 number to check max and mini ");
            Console.Write("number 1 : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("number 2 : ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("number 3 : ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (x > y && x > z)
            {
                if (y > z)
                {
                    Console.WriteLine($"the max element is {x}");
                    Console.WriteLine($"the min element is {z}");
                }
                else
                {
                    Console.WriteLine($"the max element is {x}");
                    Console.WriteLine($"the min element is {y}");

                }

            }
            else if (y > z && y > x)


            {

                {
                    if (x > z)
                    {
                        Console.WriteLine($"the max element is {y}");
                        Console.WriteLine($"the min element is {z}");
                    }
                    else
                    {
                        Console.WriteLine($"the max element is {y}");
                        Console.WriteLine($"the min element is {x}");

                    }

                }




            }
            else if (z > y && z > x)
            {


                if (x > y)
                {
                    Console.WriteLine($"the max element is {z}");
                    Console.WriteLine($"the min element is {y}");
                }
                else
                {
                    Console.WriteLine($"the max element is {z}");
                    Console.WriteLine($"the min element is {x}");

                }



            }
            else
                Console.WriteLine("that is not allow");
            #endregion
            #region Q4
            //Write a program that allows the user to insert an integer number then check If a number is even or odd.
            Console.WriteLine("Enter number to check If a number is even or odd. ");
            Console.Write("number : ");
            int mar = Convert.ToInt32(Console.ReadLine());
            if (mar % 2 == 0)
                Console.WriteLine("number is even");
            else
                Console.WriteLine("number is odd");
            Console.Clear();
            #endregion
            #region Q5
            //Write a program that takes character from the user then if it is a vowel 
            //chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            Console.WriteLine("Enter character to check if it is a vowel  or not ");
            Console.Write("character : ");
            string c = Console.ReadLine().ToLower();
            if (c == "a" || c == "e" || c == "i" || c == "o" || c == "u")
            {
                Console.WriteLine("vowel");
            }
            else
                Console.WriteLine("consonant");


            #endregion
            #region Q6
            // Write a program to enter marks of five subjects and calculate total, average and percentage.
            Console.WriteLine("enter marks of five subjects");
            Console.Write(" mark of subject 1 : ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" mark of subject 2 : ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" mark of subject 3: ");
            int m3 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" mark of subject 4 : ");
            int m4 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" mark of subject 5 : ");
            int m5 = Convert.ToInt32(Console.ReadLine());
            if (m1 >= 0 & m2 >= 0 & m3 >= 0 & m4 >= 0 & m5 >= 0)
            {
                int total = m1 + m2 + m3 + m4 + m5;
                double avg = total / 5;
                double precentage = avg;
                Console.WriteLine($"total is : {total}");
                Console.WriteLine($"averge is : {avg}");
                Console.WriteLine($"percentage is : {precentage}%");
            }
            else Console.WriteLine("enter vaild markes");

            #endregion
            #region Q7
            // Write a program to input the month number and print the number of days in that month
            Console.WriteLine("Enter the month number (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());
            int daysInMonth;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    Console.WriteLine("Enter the year:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    if (DateTime.IsLeapYear(year))
                    {
                        daysInMonth = 29;
                    }
                    else
                    { daysInMonth = 28; }
                    break;
                default:
                    Console.WriteLine("Invalid month number.");
                    return;
            }
            Console.WriteLine($"Number of days in month {month}: {daysInMonth}");
            #endregion
            #region Q8
            //Write a program to create a Simple Calculator.
            Console.WriteLine("enter two number");
            Console.Write("nuber 1 : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("nuber 2 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter an operator (+, -, *, /):");
            double result;
            char opra = Convert.ToChar(Console.ReadLine());
            switch (opra)
            {
                case '+':
                    result = number + number2;
                    Console.WriteLine($"Result is : {result}");
                    break;
                case '-':
                    if (number2 < number)

                    {
                        result = number - number2;
                        Console.WriteLine($"Result is : {result}");
                    }
                    else
                        Console.WriteLine($"You cannot subtract a smaller number from a larger number.");

                    break;
                case '*':
                    result = number * number2;
                    Console.WriteLine($"Result is : {result}");
                    break;
                case '/':

                    if (number2 > 0)
                    {
                        result = number / number2;
                        Console.WriteLine($"Result is : {result}");
                    }
                    else
                        Console.WriteLine("Cannot divide by zero.");
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;


            }



            #endregion
            #region Q9
            // Create a program that asks the user to input three points (x1, y1),
            // (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            Console.WriteLine("Enter Three points to determines whether these points lie on a single straight line ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Enter point 1");
            Console.Write("x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point 2");
            Console.Write("x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point 3");
            Console.Write("x3 : ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3 : ");
            int y3 = Convert.ToInt32(Console.ReadLine());

            try
            {

                if (((y2 - y1) / (x2 - x1)) == ((y3 - y2) / (x3 - x2)))
                {
                    Console.WriteLine("The points lie on a single straight line.");

                }

            }
            catch
            {
                Console.WriteLine("The points do not lie on a single straight line.");


            }




            #endregion
            #region Q10
            Console.WriteLine("Enter the time taken by the worker to complete the task (in hours):");
            double timeTaken = Convert.ToDouble(Console.ReadLine());
            if (timeTaken >= 2 && timeTaken < 3)
                Console.WriteLine("The worker is highly efficient.");
            else if (timeTaken >= 3 && timeTaken < 4)
                Console.WriteLine("The worker needs to increase their speed.");
            else if (timeTaken >= 4 && timeTaken < 5)
                Console.WriteLine("The worker should be provided with training to enhance their speed.");
            else if (timeTaken >= 5)
                Console.WriteLine("The worker is required to leave the company.");
            else
                Console.WriteLine("Invalid input. Please enter a valid time in hours.");
            #endregion

        }
    }
}
