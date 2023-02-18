namespace Tydz4_cw2_FizzBuzz
{
    public class FizzBuzz
    {
        public void GetNumber()
        {
            Console.WriteLine("Jeżeli chcesz zakończyć działanie aplikacji wprowadź 'T'");

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
                FizzBuzzMessage(number);
            }
        }

        public void FizzBuzzMessage(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                Console.WriteLine("Sukces! Twój wynik to 'FizzBuzz'\nJeśli chcesz grac dalej wprowadź nową liczbę.");
            else  if (number % 3 == 0)
                Console.WriteLine("Twój wynik to 'Fizz'\nJeśli chcesz grac dalej wprowadź nową liczbę.");
            else if (number % 5 == 0)
                Console.WriteLine("Twój wynik to 'Buzz'\nJeśli chcesz grac dalej wprowadź nową liczbę.");
            else
                Console.WriteLine($"Wprowadzona przez Ciebie liczba {number} nie spełnia logiki FizzBuzz. Jeśli chcesz grac dalej wprowadź nową liczbę.");
                
            GetNumber();
        }
    }
}
