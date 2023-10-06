using System;

namespace Uppgift_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett problem med valfritt räknesätt. (addition, subtraktion, division eller multiplikation)");
            string problem = Console.ReadLine();

            string räknesätt = problem.Contains("+") ? "+" : (problem.Contains("-") ? "-" : (problem.Contains("*") ? "*" : "/"));
            int räknesättindex = problem.IndexOf(räknesätt);
            string tal1Text = problem[..räknesättindex];
            string tal2Text = problem[(räknesättindex + 1)..];
            int tal1 = int.Parse(tal1Text);
            int tal2 = int.Parse(tal2Text);

            int summa = tal1 + tal2;
            int differens = tal1 - tal2;
            int produkt = tal1 * tal2;
            int kvot = tal1 / tal2;

            if (räknesätt == "+")
                Console.WriteLine("Summan är " + summa + ".");
            if (räknesätt == "-")
                Console.WriteLine("Differensen är " + differens + ".");
            if(räknesätt == "*")
                Console.WriteLine("Produkten är " + produkt + ".");
            if(räknesätt == "/")
                Console.WriteLine("Kvoten är " + kvot + ".");

            Console.ReadKey();

        }
    }
}