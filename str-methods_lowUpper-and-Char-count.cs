using System;

namespace Coding.Exercise
{
    public class Method
    {
        static void Main(string[] args)
        { }
        public static string LowUpper(string s)
        {
            return s.ToLower() + s.ToUpper();
        }

        public static void Count(string s)
        {
            Console.WriteLine("The amount of letters is {0}.", s.Length);
        }

        public static void Run()
        {
            string s = "HeY ThErE !";

            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
        }
    }
}
