using System;

namespace ExceptionHandling
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                try
                {
                    throw new InvalidOperationException("Invalid operation occurred.");
                }
                catch (InvalidOperationException ex)
                {
                    throw new ApplicationException("An application error occurred.", ex);
                }
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("Caught an exception: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner exception: " + ex.InnerException.Message);
                }
            }
            Console.ReadKey();
        }
    }


}
