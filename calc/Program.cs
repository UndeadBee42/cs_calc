using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exemple: '10 + 20'");
            bool loop = true;
            while (loop)
            { 
                string input = Console.ReadLine();
                string [] tokens = input.Split(' ');
                int res = 0;
                switch (char.Parse(tokens[1])) {
                    case '+': res = int.Parse(tokens[0]) + int.Parse(tokens[2]); break;
                    case '-': res = int.Parse(tokens[0]) - int.Parse(tokens[2]); break;
                    case '*': res = int.Parse(tokens[0]) * int.Parse(tokens[2]); break;
                    case '/': res = int.Parse(tokens[0]) / int.Parse(tokens[2]); break;
                }
                Console.WriteLine(res);
                
            }
            
        }
    }
}
