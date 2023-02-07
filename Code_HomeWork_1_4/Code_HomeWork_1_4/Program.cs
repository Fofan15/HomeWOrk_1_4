using System;

namespace Code_HomeWork_1_4
{
    /// <summary>
    /// Entry program class.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Створити масив на N елементів, де N вказується з консольного рядка
            Console.WriteLine("vedit rozmir masiva");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Заповнити його випадковими числами від 1 до 26 включно
            int[] arayNumbers = new int[size];
            Random rand = new Random();

            for (int i = 0; i < arayNumbers.Length; i++)
            {
                arayNumbers[i] = rand.Next(1, 27);
            }

            for (int i = 0; i < arayNumbers.Length; i++)
            {
                Console.Write(arayNumbers[i] + " ");
            }

            // Створити 2 масива (підрахованого заздалегідь розмір), де в 1 масиві будуть значення лише парних значень, а в другому непарних.
            int pair = 0;
            int odd = 0;

            foreach (int number in arayNumbers)
            {
                if (number % 2 == 0)
                {
                    pair++;
                }
                else
                {
                    odd++;
                }
            }

            int[] pairNumbers = new int[pair];
            int[] oddNumbers = new int[odd];
            int a = 0;
            int b = 0;

            for (int i = 0; i < arayNumbers.Length; i++)
            {
                int proof = arayNumbers[i] % 2;
                bool result = proof == 0;

                if (result)
                {
                    pairNumbers[a] = arayNumbers[i];
                    a++;
                }
                else
                {
                    oddNumbers[b] = arayNumbers[i];
                    b++;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < pairNumbers.Length; i++)
            {
                Console.Write(pairNumbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < oddNumbers.Length; i++)
            {
                Console.Write(oddNumbers[i] + " ");
            }

            Console.WriteLine();

            /*Створити ще 2 масиви символів (char) для букв розміром парних та не парних попередніх масивів чисел відповідно.
              Заповнити масиви символів (char) значення клітинок цих масивів дорівнюють порядковому номеру кожної букві в алфавіті,
              використовуючи 2 масиви парних та не парних чисел. */
            char[] pairSymbols = new char[pair];
            char[] oddSymbols = new char[odd];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < pairSymbols.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if ((pairNumbers[i] - 1) == j)
                    {
                        pairSymbols[i] = alphabet[j];
                    }
                }
            }

            for (int i = 0; i < oddSymbols.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if ((oddNumbers[i] - 1) == j)
                    {
                        oddSymbols[i] = alphabet[j];
                    }
                }
            }

            // Якщо ж буква є одній із списку (a, e, i, d, h, j) то вона має бути у верхньому регістрі
            char[] uppSymbols = new[] { 'a', 'e', 'i', 'd', 'h', 'j' };
            for (int i = 0; i < pairSymbols.Length; i++)
            {
                for (int j = 0; j < uppSymbols.Length; j++)
                {
                    if (pairSymbols[i] == uppSymbols[j])
                    {
                        pairSymbols[i] = char.ToUpper(pairSymbols[i]);
                    }
                }
            }

            for (int i = 0; i < oddSymbols.Length; i++)
            {
                for (int j = 0; j < uppSymbols.Length; j++)
                {
                    if (oddSymbols[i] == uppSymbols[j])
                    {
                        oddSymbols[i] = char.ToUpper(oddSymbols[i]);
                    }
                }
            }

            // Вивести обидва масиви на екран. Кожен з масивів має бути виведений 1 рядком, де його значення будуть розділені пропуском
            Console.WriteLine();
            for (int i = 0; i < pairSymbols.Length; i++)
            {
                Console.Write(pairSymbols[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < oddSymbols.Length; i++)
            {
                Console.Write(oddSymbols[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
