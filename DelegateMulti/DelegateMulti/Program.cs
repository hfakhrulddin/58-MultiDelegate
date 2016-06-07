using System;

namespace DelegateMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            A.Run();
            Console.ReadLine();
        }

        delegate int Calculator(int n, int m);

        static class A
        {
            public static void Run()
            {
                Calculator c = new Calculator((n, m) => n + m);
                c += new Calculator((n, m) => n * m);
                Console.WriteLine(c(c(2, 5), 4));
            }
        }
    }
}
