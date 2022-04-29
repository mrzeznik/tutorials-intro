using System.Linq;
using System.Collections.Generic;

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

                if (mouse.Color != "blue") System.Console.WriteLine($"{mouse.Brand} {mouse.Id}: This mouse is not blue, I don't like it.");
            }
            return;
        }
    }
}