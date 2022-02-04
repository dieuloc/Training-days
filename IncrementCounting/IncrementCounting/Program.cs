using System;

public class Counting
{
    public static void Main(string[] args)
    {
        for(int i = 0; i < 4; i++)
        {
            int[] count = new int[25];

            for (int j = 0; j < 25; j++)
            {               
                count[j] = j + i;
            }
            Console.WriteLine(count);
        }
    }
}
