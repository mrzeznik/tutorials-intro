using System.Linq;

namespace HelloWorld
{
    public static class TextModifications
    {
        public static string[] MakeArrayTextUpperV2(string[] args)
        {
            return args.Select(arg => arg.ToUpper()).ToArray();
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