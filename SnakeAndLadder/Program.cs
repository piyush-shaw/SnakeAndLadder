internal class Program
{
    public const int NO_PLAY = 0;
    public const int LADDER = 1;
    public const int SNAKE = 2;
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Snake And Ladder Program");
        //UC1 initializing the player position
        int position = 0;
        Console.WriteLine("Single Player starting position : " + position);
        while (position < 100)
        {
            //UC2 Roll the dice to get a number
            Random random = new Random();
            int die = random.Next(1, 7);
            //UC3 Check option for No Play,Ladder,Snake
            Random random1 = new Random();
            int option = random1.Next(0, 3);
            if (option == NO_PLAY)
            {
                Console.WriteLine("Player is at same position (NO PLAY)");
            }
            else if (option == LADDER)
            {
                position = position + die;
                Console.WriteLine("(LADDER) After getting the ladder player position is " + position);
            }
            else
            {
                position = position - die;
                if (position < 0)
                {
                    position = 0;
                }
                Console.WriteLine("(SNAKE) After snake bite player position is " + position);
            }
        }
    }
}