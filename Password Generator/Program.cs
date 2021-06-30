using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lenght: ");
            int length = Convert.ToInt32(Console.ReadLine());
            // call function
            GeneratePassword(length);
        }

        static void GeneratePassword(int length)
        {
            string password = "";
            Random random = new Random();
            int i = 0;
            do
            {
                i++;
                string[] characters = { "a", "b", "c", "d", "e" };
                int index = random.Next(characters.Length);
                password += characters[index];
            }
            while (i < length);
            Console.WriteLine(password);
        }
    }
}
