namespace Tydz4_cw2_FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź dowolną liczbę całkowitą i zagrajmy w FizzBuzz!\nJeżeli chcesz zakończyć działanie aplikacji wprowadź 'T'");

            var input = Console.ReadLine();

            while (true)
            {
                if (input.ToUpper() == "T")
                {
                    Environment.Exit(0);
                }
                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Wprowadzona liczba nie jest liczbą całkowitą lub wykracza poza jej zakres. Podaj nową liczbę całkowitą:");
                    input = Console.ReadLine();
                    continue;
                }

                input = FizzBuzz.Message(number);
            }

        }
    }
}