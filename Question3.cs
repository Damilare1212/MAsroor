 using System;
 using System.Collections.Generic;
 using System.Linq;

 namespace CodeChalenge
 {
     class Question3
     {
        public static void Answer()
        {
            string text = "the day is sunny the the the sunny is is";
               var SPLIT = text.Split(" ");

            var b = "";
          // string hold = "";
            Dictionary<string,int> dictionary = new Dictionary<string, int>();
            foreach(var item in SPLIT)
            {
                if(item != "")
                {
                    
                        b = item;
                    if (dictionary.ContainsKey(b))
                    {
                       dictionary[b] = dictionary[b] + 1;
                    }
                    else
                    {
                        dictionary.Add(b,1);
                    }
                   

                }
              
            }
            var sort = dictionary.OrderBy(item => item.Value);

            foreach(var item in sort)
            {
                 Console.Write($"{item.Key} appears {item.Value} times ");
            }
        }
        
    }
 }