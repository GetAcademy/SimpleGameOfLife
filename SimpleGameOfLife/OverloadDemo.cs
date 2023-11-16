namespace SimpleGameOfLife
{
    internal class OverloadDemo
    {
        static void Run()
        {
            var name = Console.ReadLine();
            if (name.Length > 0) Greet(name);
            else Greet();

        }

        static void Greet(string name = "du")
        {
            Console.WriteLine($"Hei, {name}!");
        }

        //static void Greet()
        //{
        //    Greet("du");
        //}
    }
}
