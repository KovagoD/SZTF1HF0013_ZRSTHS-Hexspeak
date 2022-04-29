using System;

namespace SZTF1HF0013_ZRSTHS
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Convert.ToInt64(Console.ReadLine()).ToString("X");
            string output = input.Replace("0", "O").Replace("1", "I");

            for (int i = 0; i < output.Length; i++)
            {
                if (Char.IsNumber(output[i]))
                {
                    output = "error";
                }
            }

            Console.WriteLine(output);
        }
    }
}
