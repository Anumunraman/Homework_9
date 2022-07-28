using System;
 
namespace ConsoleApp
{
    class Program
    {
        public static int Depth = 0;
        public static UInt64 AckermannFunc(UInt64 m, UInt64 n) {
            Depth++;
            if (m == 0)
                return n + 1;
            if (n == 0)
                return AckermannFunc(m - 1, 1);
            return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
        }
 
        static void Main(string[] args) {
            Console.WriteLine(AckermannFunc(3, 2));
            
        }
    }
}