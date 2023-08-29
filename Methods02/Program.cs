namespace Methods02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imperative:".ToUpper());
            RunFibImper();
            Console.WriteLine();
            Console.WriteLine("Functional:".ToUpper());
            RunFibFunc();
        }

        /// <summary>
        /// Imperative Func
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        static int FibImperative(int term)
        {
            if (term == 1)
            {
                return 0;
            }
            if (term == 2)
            {
                return 1;
            }
            else
            {
                return FibImperative(term - 1) + FibImperative(term - 2);
            }
        }
        /// <summary>
        /// Runs Imperative Func FibImperative(int term);
        /// </summary>
        static void RunFibImper()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} --> {FibImperative(i)}");
            }
        }


        /// <summary>
        /// Functional
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        static int FibFunctional(int term) => term switch
        {
            1 => 0,
            2 => 1,
            _ => FibFunctional(term - 1) + FibFunctional(term - 2)
        };

        /// <summary>
        /// It runs FibFunctional(int term);
        /// </summary>
        static void RunFibFunc()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} --> {FibFunctional(i)}");
            }
        }
    }
}