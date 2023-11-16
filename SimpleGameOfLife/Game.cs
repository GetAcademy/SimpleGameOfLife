using Console = System.Console;

namespace SimpleGameOfLife
{
    internal class Game
    {
        public static void Run()
        {
            var coloumnCount = Console.WindowWidth;
            var rowCount = Console.WindowHeight - 1;
            var cellCount = coloumnCount * rowCount;

            var random = new Random();
            var cells = new char[cellCount];
            for (int i = 0; i < cells.Length; i++)
            {
                var randomNumber0or1 = random.Next(0, 2);
                var isAlive = randomNumber0or1 == 1;
                cells[i] = isAlive ? 'O' : ' ';
            }

            Console.WriteLine(cells);
        }

        /*
           var name = Console.ReadLine();
           if(name.Length>0) Greet(name);
           else Greet();
         */

        private static void Greet(string name)
        {
            Console.WriteLine($"Hei, {name}!");
        }

        private static void Greet()
        {
            Console.WriteLine($"Hei på deg!");
        }
    }
}
