using System;
public class Exercise34
{
    public static void Main()
    {
        int num, i, ctr, n1, n2; 

        Console.Write("Input the first number : ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the second number : ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("The prime numbers between {0} and {1} are : \n", n1, n2);

        for (num = n1; num <= n2; num++)
        {
            ctr = 0;

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }
            }

            if (ctr == 0 && num != 1)
                Console.Write("{0} ", num);
        }
        Console.Write("\n");
    }
}
