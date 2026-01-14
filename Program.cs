internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        int numRolls;
        while (true) // loops until a valid input is given
        {
            Console.Write("How many dice rolls would you like to simulate? ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out numRolls) && numRolls > 0) // checks input validity then sets numRolls to input if valid
            {
                break;
            }

            Console.WriteLine("Please enter a positive integer.");
        }

        DiceRoller roller = new DiceRoller(); // make new object instance
        int[] results = roller.RollDice(numRolls); // start rolls

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numRolls}.\n");

        for (int i = 2; i <= 12; i++) // print out histogram of roll percentages
        {
            int percentage = (results[i] * 100) / numRolls;
            Console.Write($"{i}: ");

            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}