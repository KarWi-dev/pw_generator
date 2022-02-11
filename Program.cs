using System;

namespace Password_gen
{
    class Program
    {
        static void Main(string[] args)
        {
            int CharSize;
            var chors = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();

            Console.WriteLine("How many Chars? max 32:");
            CharSize = Convert.ToInt32(Console.ReadLine());
            var stringChars = new char[CharSize];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chors[random.Next(chors.Length)];
            }
            Console.WriteLine($"Ihr Your Generated PW is: {Convert.ToString(stringChars)}");
            Console.ReadKey();
        }
    }
}
