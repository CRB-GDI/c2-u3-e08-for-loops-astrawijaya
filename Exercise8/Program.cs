namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a max number: ");
            int maxNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < maxNum; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //asterisk
            Console.WriteLine("How many asterisks in a row? ");
            int astNum = Int32.Parse(Console.ReadLine());

            for (int a = 0; a < astNum; a++)
            {
                Console.Write("*");
            }

            //Console.WriteLine(maxNum);
        }
    }
}