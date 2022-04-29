namespace HelloWorld
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                var upperText = args[i].ToUpper();

                System.Console.WriteLine(upperText);
            }

            System.Console.WriteLine("Hello, World!");

            return;
        }
    }
}