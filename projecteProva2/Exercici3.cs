//PRE: rep 3 números
using System;

namespace projecteProva
{
    public class Exercici3
    {
        public static bool ValidateInRange(int num, int min, int max)
        {
            return min <= num && num <= max;
        }
        public static void Main()
        {
            const string AskDay = "Introdueix el dia: ";
            const string AskMonth = "Introdueix el mes: ";
            const string AskYear = "Introdueix l'any: ";
            const string DayInRange = "Dia en rang!";
            const string MonthInRange = "Mes en rang!";
            const string YearInRange = "Any en rang!";
            const string FormatError = "Incorrect format. Try again.";
            const string OverflowError = "Incorrect format. Try again.";
            const string UnknownError = "Unknown error. Try again.";

            int dia = 0;
            int mes = 0;
            int any = 0;
            int totalDaysMonth; //He deixat aquestes dues variables perquè potser es volen utilitzar
            int februaryDays; //Posteriorment en una nova característica del programa
            bool validat;

            do
            {
                try
                {
                    Console.Write(AskDay);
                    dia = Convert.ToInt32(Console.ReadLine());
                    if (!ValidateInRange(dia, 1, 31))
                    {
                        validat = false;
                    } else
                    {
                        validat = true;
                        Console.WriteLine(DayInRange);
                    }
                } catch (FormatException)
                {
                    Console.WriteLine(FormatError);
                    validat = false;
                } catch (OverflowException)
                {
                    Console.WriteLine(OverflowError);
                    validat = false;
                } catch (Exception)
                {
                    Console.WriteLine(UnknownError);
                    validat = false;
                }
            } while (!validat);

            do
            {
                try
                {
                    Console.Write(AskMonth);
                    mes = Convert.ToInt32(Console.ReadLine());
                    if (!ValidateInRange(mes, 1, 12))
                    {
                        validat = false;
                    }
                    else
                    {
                        validat = true;
                        Console.WriteLine(MonthInRange);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(FormatError);
                    validat = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine(OverflowError);
                    validat = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(UnknownError);
                    validat = false;
                }
            } while (!validat);

            do
            {
                try
                {
                    Console.Write(AskYear);
                    any = Convert.ToInt32(Console.ReadLine());
                    validat = true;
                    Console.WriteLine(YearInRange); //No he posat rang als anys perquè literalment van de menys infinit a més infinit
                }
                catch (FormatException)
                {
                    Console.WriteLine(FormatError);
                    validat = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine(OverflowError);
                    validat = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(UnknownError);
                    validat = false;
                }
            } while (!validat);

            if ((ValidateInRange(mes, 1, 7) && (mes%2!=0)) || (ValidateInRange(mes, 8, 12) && (mes % 2 == 0))){
                totalDaysMonth = 31;
            } else
            {
                totalDaysMonth = 30;
            }
            if ((any % 400 == 0) || ((any % 4 == 0) && (any % 100 != 0)))
            {
                februaryDays = 29;
            } else
            {
                februaryDays = 28;
            }
        }
    }
}
//POST: retorna si els números (dd, mm, yyyy) estan dins del rang de data corresponent