using System.Runtime.CompilerServices;

namespace Tydz4_cw2_FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź dowolną liczbę całkowitą i zagrajmy w FizzBuzz!");

            FizzBuzz newTry= new FizzBuzz();
            newTry.GetNumber();
        }
    }
}