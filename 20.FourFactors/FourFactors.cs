using System;

namespace _20.FourFactors
{
    class FourFactors
    {
        static void Main()
        {
            double FG = double.Parse(Console.ReadLine());
            double FGA = double.Parse(Console.ReadLine());
            double ThreeP = double.Parse(Console.ReadLine());
            double TOV = double.Parse(Console.ReadLine());
            double ORB = double.Parse(Console.ReadLine());
            double OppDRB = double.Parse(Console.ReadLine());
            double FT = double.Parse(Console.ReadLine());
            double FTA = double.Parse(Console.ReadLine());
            Console.WriteLine("eFG% {0:F3}", (FG + 0.5d * ThreeP) / FGA);
            Console.WriteLine("TOV% {0:F3}", TOV / (FGA + 0.44d * FTA + TOV));
            Console.WriteLine("ORB% {0:F3}", ORB / (ORB + OppDRB));
            Console.WriteLine("FT% {0:F3}", FT / FGA);
        }
    }
}
