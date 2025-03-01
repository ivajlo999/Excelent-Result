using System.ComponentModel;

namespace Poznai_Parolata
{
    internal class Program
    {
        static void Main(string[] argz)
        {
            Console.WriteLine("Въведи парола");
            var password = (Console.ReadLine());
            if (password == "secretPassword")
            {
                Console.WriteLine("Welcome!");
            }
            else 
            {
                Console.WriteLine("Wrong Password!");
            }
     

            
        }
    } 
}
