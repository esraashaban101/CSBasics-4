namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1-- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }

            #endregion
            #region Q2-Write a program that allows the user to insert an integer then  print a multiplication table up to 12.
            int M = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(M * i);

            }
            #endregion
            #region Q3-Write a program that allows to user to insert number then print all even numbers between 1 to this number
            int Evens = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Evens; i++)
            {
                if (i % 2 == 0)
                { Console.WriteLine(i); }
            }
            #endregion

            #region Q4-Write a program that takes two integers then prints the power.
            int Fnum = int.Parse(Console.ReadLine()), Lnum = int.Parse(Console.ReadLine());
            int Count = 1, result = 1;
            while (Count <= Lnum)
            {
                result *= Fnum;

                Count++;
            }
            Console.WriteLine(result);
            #endregion

            #region Q5-- Write a program to enter marks of five subjects and calculate total, average and percentage.
            int s1 = int.Parse(Console.ReadLine()), s2 = int.Parse(Console.ReadLine()),
                s3 = int.Parse(Console.ReadLine()), s4 = int.Parse(Console.ReadLine()), s5 = int.Parse(Console.ReadLine());
            int Sum = s1 + s2 + s3 + s4 + s5;
            int Average = Sum / 5;
            int percentage = Average;
            Console.WriteLine($"Total marks = {Sum}");
            Console.WriteLine($"Average Marks =  {Average}");
            Console.WriteLine($"Pecentage =  {percentage}");
            #endregion

            #region Q6- Write a program to input the month number and print the number of days in that month.
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine($"Days in Month : {DateTime.DaysInMonth(2024, month)}");
            #endregion

            #region Q7-Write a program to create a Simple Calculator.

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");

            #endregion

            #region Q8- Write a program to allow the user to enter int and print the REVERSED of it.

            int NumberToReverse = int.Parse(Console.ReadLine());
            string ReversedString = Convert.ToString(NumberToReverse);
            for (int i = ReversedString.Length - 1; i >= 0; i--)
            {
                Console.Write(ReversedString[i]);
            }

            #endregion

            #region Q9- Write a program in C# Sharp to find prime numbers within a range of numbers.

            int prime = int.Parse(Console.ReadLine());

            for (int i = 2; i <= prime; ++i)
            {
                int cnt = 0;

                for (int j = 1; j <= i; ++j)
                {
                    if (i % j == 0)
                    {

                        cnt++;
                    }
                   
                }
                if (cnt <= 2)
                    Console.WriteLine(i);
            }

            #endregion

            #region Q10-Write a program in C# Sharp to convert a decimal number into binary without using an array.

            int BinaryNum = int.Parse(Console.ReadLine());
            string BinaryStr = "";
            int OriginalNum = BinaryNum;
            while (BinaryNum > 0)
            {
                if (BinaryNum % 2 == 0)
                    BinaryStr += "0";
                else
                    BinaryStr += "1";
                BinaryNum /= 2;


            }
            Console.Write($"The Binary of {OriginalNum} is ");
            for (int i = BinaryStr.Length - 1; i >= 0; i--)
            {
                Console.Write(BinaryStr[i]);
            }

            #endregion

        }
    }
}
