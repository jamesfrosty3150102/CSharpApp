using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Mixed_Mode_Calling_App
{
    class Program
    {
        [DllImport(@"D:\CSharp\MixCode\Mixed_Mode_Debugging\Debug\Mixed_Mode_Debugging.dll", EntryPoint = "mixed_mode_multiply", CallingConvention = CallingConvention.StdCall)]
        public static extern int Multiply(int x, int y);
        static void Main(string[] args)
        {
            int result = Multiply(7, 7);
            Console.WriteLine("The answer is {0}", result);
            Console.ReadKey();
       }
    }
}
