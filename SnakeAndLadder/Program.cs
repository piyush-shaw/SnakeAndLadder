internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Snake And Ladder Program");
        //UC1 initializing the player position
        int position = 0;
        Console.WriteLine("Single Player starting position : " + position);
        //UC2 Roll the dice to get a number
        Random random = new Random();
        int die = random.Next(1, 7);
        Console.WriteLine("After rolling the die Single Player position "+die);
    }
}