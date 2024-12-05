using System;
using Prova;

namespace Exercise_Two
{
    public class Program
    {
        public static void Main()
        {
            const string AskNum = "Please type a number: ";
            const string NumInArray = "Your number was in the array";
            const string NumNotInArray = "Your number was not in the array";
            const string FormatError = "Incorrect format. Try again.";
            const string OverflowError = "Incorrect format. Try again.";
            const string UnknownError = "Unknown error. Try again.";

            bool validProcess;
            int userNum = 0;
            int[] array = { 10, -4, 6, 4, 8, 13, 2, -4 };

            do
            {
                try
                {
                    Console.Write(AskNum);
                    userNum = Convert.ToInt32(Console.ReadLine());
                    validProcess = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine(FormatError);
                    validProcess = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine(OverflowError);
                    validProcess = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(UnknownError);
                    validProcess = false;
                }
            } while (!validProcess);

            if (SearchClass.BinarySearch(array, 0, array.Length, userNum) != -1)
            {
                Console.WriteLine(NumInArray);
            } else
            {
                Console.WriteLine(NumNotInArray);
            }
            FirstSort.Order(array, 0, array.Length); //No sé per què no funciona
            foreach (int num in array)
            {
                Console.Write($"{num} ");
            }
        }
    }
}