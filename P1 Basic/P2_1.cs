using System;

public class P2_1
{
    public P2_1()
    {
    }
        public static void Main(String[] args)
        {
        for (int i = 5; i > 0; i--)
        {
            for (int j = i; j > 0; j--)
            {
                Console.Write("@");
            }
            Console.WriteLine("");
        }
    }
}
