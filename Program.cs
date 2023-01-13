using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static string[] input1 = new string[]
        {
                "flower",
                "flounder",
                "floss",
                "flop"
        };

        static string[] input2 = new string[]
        {
                "", "", "flower"       
        };

        static string[] input3 = new string[]
        {
                "stupid",
                "can"
        };

        static void Main(string[] args)
        {
            var lcp = Vertical(input2);
            Console.WriteLine($"prefix REAL RESULT: [{lcp}]");
        }

        public static string Vertical(string[] input) //vertical
        {
            if(input.Length==0)
            {
                return "";
            }
            string prefix = input[0];
            
            for(int i =0;i<input.Length;i++)
            {
                Console.WriteLine($"horizontal(baseline:{input[0]}, input[{i}]: {input[i]})");

                prefix=Horizontal(prefix, input[i]);
                Console.WriteLine($"end result: {prefix}");
            }

            return prefix;
        }

        public static string Horizontal (string baseline, string after) //horizontal
        {
            string prefix = "";
            int length = Math.Min(baseline.Length, after.Length);

            for(int i=0;i<length;i++)
            {

                //Console.WriteLine($"baseline:{baseline[i]}"+$"after:{after[i]}");
                if (baseline[i] != after[i])
                {
                    return prefix;
                }
                prefix = prefix + baseline[i];
            }

            return prefix;
        }
       
    }
}
