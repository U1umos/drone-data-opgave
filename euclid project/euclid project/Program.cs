namespace RekursionsOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(gcd(291, 129));
            Console.WriteLine(gcd2(291, 129));
        }


        static int gcd(int m, int n)
        {
            // M skal være større eller lige med n, og n skal være større end 0.

            int tmp;
            while (m % n > 0)
            {
                tmp = n;
                n = m % n;
                m = tmp;
            }

            return n;
        }

        static int gcd2(int m, int n)
        {
            // M skal være større eller lige med n, og n skal være større end 0.

            if (m % n == 0)
                return n;
            else
                return gcd2(n, m % n);
        }


    }
}