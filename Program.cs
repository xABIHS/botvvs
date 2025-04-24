using System;

class Program
{
    private static void Main(string[] args)
    {
        string name = Console.ReadLine();
        Console.WriteLine($"Привет {name}");

        while (true)
        {
            string cmd = Console.ReadLine();

            if (cmd == "exit")
            {
                Console.WriteLine($"До свидания, {name}");
                break;
            }
        }
    }
}
