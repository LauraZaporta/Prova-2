using System;

namespace projecteProva
{
    public class Exercici5
    {
        public static bool FindNumberInArray(int[] array, int num)
        {
            int i = 0;
            bool found = false;
            while (i < array.Length && !found) {
                if (array[i] == num) found = true;
                i++;
            }
            return found;
        }
        public static void QuickChange(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        QuickChange(ref array[i], ref array[j]);
                    }
                }
            }
        }

        public static void Main()
        {
            const string AskNumA = "Type a number ";
            const string AskNumB = " of ";
            const string NumberInArr = "Your number is in the array!";
            const string NumberNotInArr = "Your number is not in the array!";
            const string FormatError = "Incorrect format. Try again.";
            const string OverflowError = "Incorrect format. Try again.";
            const string UnknownError = "Unknown error. Try again.";

            bool validProces;
            int numUserFind = 0;
            int[] array = new int[20];

            //PART a)
            for (int i = 0; i < array.Length; i++)
            {
                do
                {
                    try
                    {
                        Console.Write($"{AskNumA}{i + 1}{AskNumB}{array.Length}: ");
                        array[i] = Convert.ToInt32(Console.ReadLine());
                        validProces = true;
                    } catch (FormatException)
                    {
                        Console.WriteLine(FormatError);
                        validProces = false;
                    } catch (OverflowException)
                    {
                        Console.WriteLine(OverflowError);
                        validProces = false;
                    } catch (Exception)
                    {
                        Console.WriteLine(UnknownError);
                        validProces = false;
                    }
                } while (!validProces); 
            }
            BubbleSort(array);
            foreach(int num in array)
            {
                Console.Write($"{num} ");
            }

            //PART b)
            do
            {
                try
                {
                    Console.Write(AskNumA);
                    numUserFind = Convert.ToInt32(Console.ReadLine());
                    validProces = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine(FormatError);
                    validProces = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine(OverflowError);
                    validProces = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(UnknownError);
                    validProces = false;
                }
            } while (!validProces);

            if (FindNumberInArray(array, numUserFind))
            {
                Console.WriteLine(NumberInArr);
            } else
            {
                Console.WriteLine(NumberNotInArr);
            }
        }
    }
}