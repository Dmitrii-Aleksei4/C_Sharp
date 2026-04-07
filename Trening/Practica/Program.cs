namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(primer(3));
            Console.WriteLine(primer(3,5));
            Console.WriteLine(primer(3,5,4));
            //primer(3,5,6);
        }

        static int primer (int a)
        {
            return a;

        }

        static int primer(int a, int b)
        {
            int sum = a + b;
            return sum;

        }

        //static void primer(params int[] vse_int)
        //{
        //    foreach (int vse in vse_int)
        //    {
        //        Console.WriteLine(vse);
                
        //    }
            
        //}

        static int primer(params int[] vse_int)
        {
            foreach (int vse in vse_int)
            {
                Console.WriteLine(vse);
                
            }
            return 0;
        }

    }
}
