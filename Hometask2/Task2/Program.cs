using System;

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Please enter a name");
            int number = Console.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the digits of the number" + showSumOfTheDigits(number));
            #endregion
        }

    static int showSumOfTheDigits(int number)
        {
            int sum = 0;
            int digit = 0;
            while (number > 0)
            {
                digit = number % 10;
                number /= 10;
                sum += digit;
            }
            return sum;

            {

                #region Task 2
                Console.WriteLine("Please enter the first number");
                int num1 = Convert.ToInt32(Console.Readline());
                int num2 = Covert.ToInt32(Console.ReadLine());
                Console.WriteLine($"21e bolunen ededlerin ededi ortasi: {showSumOfTheDigits(num1, num2)}");
                #endregion
            }
            static int showSumOfTheDigits(int number);
             
            static double sumDigits (int n, int m)
            {
                int sum = 0;
                double count = 0;
                if (n < m)
                {
                    for(int i= n; i < m; i++)
                    {
                        if (i % 21 == 0)
                        {
                            count++;
                            sum += i;
                        }
                    }
                }
                return sum / count;
            }

            {
                #region Task 3
                Console.WriteLine("Please enter a word");
                string wordStr = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Bu yazida a herfi: " + wordLetter(wordStr));

                #endregion

            }

            static int showSumOfTheDigits(int number)

            static double sumDigits(int n, int m)
            
                static bool wordLetter(string wordStr)
            {
                bool polo = false;
                for (int i = 0; i < wordStr.Length; i++)
                {
                    if (wordStr[i] == 'a')
                    {
                        polo = true;
                        break;
                    }
                }
                return polo;
            }


        }

    }
}
