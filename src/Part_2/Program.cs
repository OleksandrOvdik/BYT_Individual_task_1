namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo");

            Calculator addition = new Calculator(9, 11, '+');
            Console.WriteLine($"9 + 11 = {addition.Calculate()}");

            Calculator multiplication = new Calculator(14, 48, '*');
            Console.WriteLine($"14 * 48 = {multiplication.Calculate()}");

            Calculator division = new Calculator(100, 10, '/');
            Console.WriteLine($"100 / 10 = {division.Calculate()}");

            Console.WriteLine("\nErrores");

            try
            {
                Calculator zeroDivCalc = new Calculator(15, 0, '/');
                zeroDivCalc.Calculate();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            try
            {
                Calculator invalidOpCalc = new Calculator(5, 5, '%');
                invalidOpCalc.Calculate();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}