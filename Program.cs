namespace stemhokje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool heelgoedeloop = true;
            int dominique = 0;
            int zacharia = 0;
            while (heelgoedeloop)
            {
                Console.WriteLine("president Dominique of president Zacharia?");
                string stem = Console.ReadLine();
                string stemlower = stem.ToLower();
                if (stemlower.Contains("dominique"))
                {
                    Console.WriteLine("je hebt gestemd");
                    dominique++;
                }
                else if (stem.Contains("zacharia"))
                {
                    Console.WriteLine("je hebt gestemd");
                    zacharia++;
                }
                else if (stem.Contains("uitslag"))
                {
                    Console.WriteLine($"die uh dominogwattes heeft {dominique} aantal stemmen");
                    Console.WriteLine($"die andere heeft {zacharia} aantal stemmen");
                    if (dominique > zacharia)
                    {
                        Console.WriteLine("wow dominogwattes wint");
                    }
                    else if (zacharia > dominique)
                    {
                        Console.WriteLine("wow zacharia wint");
                    }
                    else if (zacharia == dominique)
                    {
                        Console.WriteLine("hoe is het gelijkspel geworden wat");
                    }
                    Environment.Exit(0);
                }
            }
        }
    }
}