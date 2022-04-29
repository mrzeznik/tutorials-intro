using System.Linq;

namespace HelloWorld
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var upperTextArrayArgs = MakeArrayTextUpper(args);


            return;
        }

        public static string[] MakeArrayTextUpper(string[] sourceArray)
        {
            if (sourceArray == null || sourceArray.Length == 0) return new string[0];

            var targetArray = new string[sourceArray.Length];

            for (int i = 0; i < sourceArray.Length; i++)
            {
                targetArray[i] = sourceArray[i].ToUpper();
            }

            return targetArray;
        }
    }
}