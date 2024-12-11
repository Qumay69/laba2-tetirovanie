using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("X | Y | Z | Expression 1 | Expression 2");
        for (int X = 0; X <= 1; X++)
        {
            for (int Y = 0; Y <= 1; Y++)
            {
                for (int Z = 0; Z <= 1; Z++)
                {
                    bool expr1 = !(X == 1 && Y == 1) || (X == 1 && Z == 0);

                    bool expr2 = (X == 1 && (Y == 0 || Z == 1)) || Y == 1;

                    Console.WriteLine($"{X} | {Y} | {Z} | {Convert.ToInt32(expr1)} | {Convert.ToInt32(expr2)}");
                }
            }
        }
    }
}
