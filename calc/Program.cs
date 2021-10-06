using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program started");
            bool loop = true;
            while (loop)
            { 
                string input = Console.ReadLine();
                string [] tokens = input.Split(' ');
                if (tokens[0] == "quit") { return; }
                int res = 0;
                switch (char.Parse(tokens[1])) {
                    case '+': res = int.Parse(tokens[0]) + int.Parse(tokens[2]); break;
                    case '-': res = int.Parse(tokens[0]) - int.Parse(tokens[2]); break;
                    case '*': res = int.Parse(tokens[0]) * int.Parse(tokens[2]); break;
                    case '/': res = int.Parse(tokens[0]) / int.Parse(tokens[2]); break;
                }
                Console.WriteLine(res);
                Console.WriteLine("quit y/n");
                input = Console.ReadLine();
                if (input == "y") { return; }
            }
            
        }
    }
}
