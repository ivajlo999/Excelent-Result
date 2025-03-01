namespace po_golqmoto_chislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("въведи две числа");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"По Голямото число е {a} ");
            }
            else
            {
                Console.WriteLine($"По Голямото число е {b} ");
            }

        }
    }
}
