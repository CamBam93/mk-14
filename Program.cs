using System;
using System.Threading;
using System.Transactions;

namespace Intro_exer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, verb, adj, adj_a;

            Console.Write("Enter a Color:");
            color = Console.ReadLine();
            Console.Write("Enter a Verb:");
            verb = Console.ReadLine();
            Console.Write("Enter a Adjective:");
            adj = Console.ReadLine();
            Console.Write("Enter another Adjective:");
            adj_a = Console.ReadLine();

            Console.WriteLine("The " + color + " cat");
            Console.WriteLine(verb + " at the old man");
            Console.WriteLine("The old man was " + adj);
            Console.WriteLine("But the Cat was " + adj_a);

            Console.ReadLine();
        }
    }
}
