namespace Tydz4_cw2_FizzBuzz
{
    public class FizzBuzz
    {
        public static string Message(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                Console.WriteLine("Sukces! Twój wynik to 'FizzBuzz'\nJeśli chcesz grac dalej wprowadź nową liczbę.");
            else  if (number % 3 == 0)
                Console.WriteLine("Twój wynik to 'Fizz'\nJeśli chcesz grac dalej wprowadź nową liczbę.");
            else if (number % 5 == 0)
                Console.WriteLine("Twój wynik to 'Buzz'\nJeśli chcesz grac dalej wprowadź nową liczbę.");
            else
                Console.WriteLine($"Wprowadzona przez Ciebie liczba {number} nie spełnia logiki FizzBuzz. Jeśli chcesz grac dalej wprowadź nową liczbę.");

            var output = Console.ReadLine();
            
            return output;
        }

        
        public static string GetOutput(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";
            
            return number.ToString();
        }
    }
}
