using System.Linq;
using System.Collections.Generic;

namespace HelloWorld
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // var upperTextArrayArgs = TextModifications.MakeArrayTextUpper(args);

            var mouseToCheck = new Mouse();

            // create a new Mouse
            if (args.Length == 6)
            {
                mouseToCheck.Brand = args[0];
                mouseToCheck.IsWireless = bool.Parse(args[1]);
                mouseToCheck.NumberOfButtons = int.Parse(args[2]);
                mouseToCheck.Color = args[3];
                mouseToCheck.HasLight = bool.Parse(args[4]);
                mouseToCheck.Price = decimal.Parse(args[5]);
            }

            var mouseToCheck2 = new Mouse() { Brand = "Logitech" };
            var mouseToCheck3 = new Mouse() { Brand = "Microsoft", Color = "blue" };
            var mouseToCheck4 = new Mouse() { Brand = "A4Tech", Color = "red", IsWireless = false };

            var mouseList = new List<Mouse>() { mouseToCheck, mouseToCheck2, mouseToCheck3, mouseToCheck4 };
            mouseList.Add(mouseToCheck3);

            foreach (var mouse in mouseList)
            {
                if (mouse.IsWireless)
                {
                    System.Console.WriteLine($"{mouse.Brand} {mouse.Id}: This is a wireless mouse.");
                }
                else
                {
                    System.Console.WriteLine($"{mouse.Brand} {mouse.Id}: This is a wired mouse.");
                }

                if (mouse.Color != "blue") System.Console.Write("This mouse is not blue, I don't like it.");
            }

            return;
        }
    }
}