using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata20170731
{
    class Program
    {
        static void Main(string[] args)
        {
            AverageString("zero nine five two");
            AverageString("four six two three");
            AverageString("one two three four five");
            AverageString("five four");
            AverageString("zero zero zero zero zero");
            AverageString("one one eight one");
            AverageString("");
            

            Console.ReadLine();
            return;
        }

        
        public static string AverageString(string str)
        {
            //deal with special case
            if (str == "")
                return "n/a";
            else
            {
                Dictionary<string, string> numMap = new Dictionary<string, string>();

                numMap.Add("zero", "0");
                numMap.Add("one", "1");
                numMap.Add("two", "2");
                numMap.Add("three", "3");
                numMap.Add("four", "4");
                numMap.Add("five", "5");
                numMap.Add("six", "6");
                numMap.Add("seven", "7");
                numMap.Add("eight", "8");
                numMap.Add("nine", "9");


                //split input string
                string[] originalString = new string[100];
                originalString = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                //transfer to int
                int sum = 0;
                foreach (string ss in originalString)
                {
                    sum += int.Parse(numMap[ss]);
                }


                //calculate avg
                int avg = sum / originalString.Count();


                //transfer to string
                var myKey = numMap.FirstOrDefault(x => x.Value == avg.ToString()).Key;
                Console.Write(myKey.ToString());

                return myKey.ToString();
            }
            
            
        }
    }
}
