using System.Linq;

namespace HelloWorld
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // var upperTextArrayArgs = TextModifications.MakeArrayTextUpper(args);

            // create a new Mouse
            var mouseToCheck = new Mouse()
            {
                Brand = args[0],
                IsWireless = bool.Parse(args[1]),
                NumberOfButtons = int.Parse(args[2]),
                Color = args[3],
                HasLight = bool.Parse(args[4]),
                Price = decimal.Parse(args[5])
            };

            return;
        }
    }
}