 using System;
 using System.Collections.Generic;
 using System.Linq;

 namespace CodeChalenge
 {
     class Question2
     {
        public static void Answer()
        {
            string[] input = {"abcw", "baz", "foo", "xtfn", "abcdef"};

            var ansewr =  MaximumValue(input);
            Console.WriteLine(ansewr);
        }

        public static int MaximumValue(string[] x)
        {
            var hash = x.Select(it=>it.ToHashSet()).ToArray();
            var max = 0;

            for(int i = 0; i<x.Length; i++)
            {
                for (int j= i +1; j<x.Length; j++)
                {
                    if (!hash[i].Overlaps(hash[j]))
                    {
                        max = Math.Max(max,x[i].Length * x[j].Length );
                    }
                }
            }
            return max;
        }
     }
 }