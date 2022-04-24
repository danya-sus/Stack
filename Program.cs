using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Minion();
            var m2 = new Minion();
            var m3 = new Minion();
            var m4 = new Minion();
            var m5 = new Minion();

            m1.Name = "Ivan";
            m2.Name = "Dima";
            m3.Name = "Sasha";
            m4.Name = "Nikita";
            m5.Name = "Artem";

            var stack = new Stack<Minion>();

            stack.Push(m1); //Ivan
            stack.Push(m5); //Artem, Ivan
            stack.Push(m2); //Dima, Artem, Ivan
            stack.Push(m4); //Nikita, Dima, Artem, Ivan

            foreach (var s in stack)
            {
                Console.WriteLine($"{s.Name}");
            }

            stack.Pop(); //Dima, Artem, Ivan
            Console.WriteLine("\n-------------------\n");

            foreach (var s in stack)
            {
                Console.WriteLine($"{s.Name}");
            }

            stack.Push(m3); //Sasha, Dima, Artem, Ivan
            Console.WriteLine("\n-------------------\n");

            foreach (var s in stack)
            {
                Console.WriteLine($"{s.Name}");
            }

            Console.WriteLine("\n\n\nAny key to end...");
            char x = Convert.ToChar(Console.ReadKey());
        }
    }
}
