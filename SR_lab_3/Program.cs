using System;

namespace SR_lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 3500;
            int krozyabra = 65;

            int k = t/(t + (krozyabra*4));
            Console.WriteLine("K = {0}", k);
        }
    }
}
