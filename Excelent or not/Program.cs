namespace Excelent_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if ( grade >= 5.50)
            {
                Console.WriteLine("Excelent!");
            }
            else
            { 
            
                Console.WriteLine("Not Excelent");
            }

        }
    }
}
