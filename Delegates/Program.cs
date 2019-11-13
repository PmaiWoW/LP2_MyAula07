using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            StrConcat strConcat = new StrConcat("boi");

            VoidStringDelegate StringChains = PrintUpper;
            StringChains += PrintLower;
            StringChains += strConcat.ConcatAndPrint;

            StringChains("go away ");
        }
       
        public static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
       
        public static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }
    }
}
