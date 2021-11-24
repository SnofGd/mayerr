using System;

namespace _2323
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("******************");
            Console.WriteLine("***Тест Пратики***");
            int i = 5;

            Console.WriteLine("******************");
            // Основка
            int b = 3;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            int c = i + b;
            Console.WriteLine("Проверчока практики");
            // там будет ожидание, надо бут ентер нажать
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
