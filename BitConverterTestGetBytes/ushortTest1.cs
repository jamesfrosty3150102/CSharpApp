using System;

namespace ushortTest1
{
    class ushortTest1
    {
        static void Main(string[] args)
        {
            ushort abc = 0xFF;
            Console.WriteLine(abc);
            byte[] abc1 = null;
            abc1 = BitConverter.GetBytes(abc);
            for (int i = 0; i < abc1.Length; i++)
            {
                Console.WriteLine(abc1[i].ToString("X"));
            }
        }
    }
}
