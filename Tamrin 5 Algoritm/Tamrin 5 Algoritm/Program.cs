using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin_5_Algoritm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritm_1();
            //Algoritm_2();
            //Algoritm_3();
            //Algoritm_4();
            Algoritm_5();

            Console.ReadKey();
        }

        #region Algoritm 1

        static void Algoritm_1()
        {
            int minimumAge = 1000;
            int maximumAge = -1;
            int age = 0;
            int total = 0;

            Console.Write("Please Enter the number of people : ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Please Enter age of Person {i + 1} : ");
                age = Convert.ToInt32(Console.ReadLine());

                total += age;

                if (age < minimumAge)
                    minimumAge = age;

                if (age > maximumAge)
                    maximumAge = age;
            }

            Console.WriteLine("Minimum Age is : " + minimumAge);
            Console.WriteLine("Maximum Age is : " + maximumAge);
            Console.WriteLine("Average of Age is : " + total / count);
        }

        #endregion

        #region Algoritm 2

        static void Algoritm_2()
        {
            Console.Write("Please Enter Fibonachi number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int f = FibonachiNumber(number);
            Console.WriteLine("Fibonachi Number is : " + f);
        }

        static int FibonachiNumber(int number)
        {
            if (number < 3)
                return number - 1;

            return FibonachiNumber(number - 1) + FibonachiNumber(number - 2);
        }

        #endregion

        #region Algoritm 3

        static void Algoritm_3()
        {
            Console.Write("Please Enter Factor Row : ");

            int Row = Convert.ToInt32(Console.ReadLine());
            float TotalPrice = 0;

            int productCount = 0;
            int productPrice = 0;

            for (int i = 0; i < Row; i++)
            {
                Console.Write($"Please Enter Product Count {i + 1} : ");
                productCount = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please Enter Product Price : ");
                productPrice = Convert.ToInt32(Console.ReadLine());

                TotalPrice += (productCount * productPrice);
            }

            TotalPrice *= 0.14f;

            Console.WriteLine("profit is : " + TotalPrice);
        }

        #endregion

        #region Algoritm 4

        static void Algoritm_4()
        {
            Console.Write("Please Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine(number / 2);
            else
                Console.WriteLine(number * 2);
        }

        #endregion

        #region Algoritm 5

        static void Algoritm_5()
        {
            Console.Write("Please Enter a number of row : ");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }
        }

        #endregion
    }
}
