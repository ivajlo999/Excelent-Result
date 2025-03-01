using System.ComponentModel.Design;

namespace Ednakvi_dumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word1 = Console.ReadLine();
            var word2 = Console.ReadLine();
            if  (word1 == word2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }   
    }
}
