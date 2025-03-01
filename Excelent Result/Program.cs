using System.ComponentModel.Design;

namespace Excelent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50) 
            {
                Console.WriteLine("Excelent");

            }
        }   
    }
}
