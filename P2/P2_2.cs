using System;

public class P2_2
{
	public P2_2()
	{
	}
    public static void Main(String[] args)
    {
        int k = Convert.ToInt32(args[0]);
        for (int i = 1; i < k + 1; i++)
        {
            for (int j = 1; j < i + 1; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine("");
        }
    }


}
