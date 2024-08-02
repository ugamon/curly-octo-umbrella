using Quest.Domain;


namespace Quest
{
    internal class Game
    { 

        public Game()
        {

        }

        public void Start() {
            char k;
            do
            {
                Console.WriteLine("Press x to exit");
                k = Console.ReadKey().KeyChar;

            }
            while (k != 'x');
        }
    }
}
