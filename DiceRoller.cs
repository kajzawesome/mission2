using System;

public class DiceRoller
{
	public DiceRoller() // no info needed to save, empty constructor
	{
	}

    public int[] RollDice(int numRolls)
    {
        int[] results = new int[13]; 
            // make array for storing 0 - 12 (0 & 1 not used but keeping the array size helps things line up
        Random rand = new Random();

        for (int i = 0; i < numRolls; i++)
        {
            int die1 = rand.Next(1, 7); // as small as 1 and big as 6
            int die2 = rand.Next(1, 7);
            int sum = die1 + die2;

            results[sum]++; // add into the array so we track results
        }

        return results;
    }
}
