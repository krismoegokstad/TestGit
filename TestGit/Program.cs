namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kristian, Moe!");
            
            // Call the new CountTo100 function
            CountTo100();
        }

        // Function to count to 100
        static void CountTo100()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}