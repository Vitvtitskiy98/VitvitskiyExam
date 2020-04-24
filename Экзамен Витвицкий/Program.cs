using System;


namespace Экзамен_Витвицкий
{
    class Program
    {
        public static void PrintStr(string str) => Console.WriteLine(str);
        static void Main(string[] args)
        {
        PrintStr("задание: С клавиатуры вводятся числа. Суммировать числа до тех пор, пока сумма не станет больше 100.\n" +
                    "Вывести сумму и количество просуммированных чисел.");
                int summa = 0;
                int count = 0;
        m: Console.WriteLine("Введите число:");
            try
            {
                while (summa < 100)
                {
                   
                    int number = int.Parse(Console.ReadLine());
                    summa += number;
                    count++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto m;
             
            }
                Console.WriteLine($"Количество просуммированных чисел {count}, сумма {summa}.");
                Console.WriteLine("Для завершения программы нажмите клавишу Enter...");
                Console.ReadLine();
            }
        }
    }

    