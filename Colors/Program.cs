using System;
using System.IO;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your fav color:");
            string userSign = Console.ReadLine();
            Console.WriteLine(GetHoroscope(userSign));

        }
        public static string[] ReadHoroscope()
        {
            string filePath = @"C:\Users\opilane\Samples\personality.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }
        public static string GetHoroscope(string userInput)
        {
            string[] horoscope = ReadHoroscope();
            string todayHoroscope = "";

            foreach (string element in horoscope)
            {
                if (element.Contains(userInput))
                {
                    todayHoroscope = element;
                }
            }

            return todayHoroscope;
        }
    }
}
