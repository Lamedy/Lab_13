using System;

namespace Lab_13
{
    class printHello
    {
        public static void print()
        {
            Console.WriteLine("Hello World!");
        }
    }

    public delegate void printHelloDelegate();
    internal class Program
    {
        

        class Box<T1>
        {
            T1 value;
            public Box(T1 value)
            {
                this.value = value;
            }
        };
        static void Main(string[] args)
        {
            Box<int> body = new Box<int>(12);

            printHelloDelegate test = new printHelloDelegate(printHello.print);

            test();

            System.Console.ReadLine();
        }
    }
}