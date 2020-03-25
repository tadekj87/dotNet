using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public static List<string> MillNumbers(List<int> numbers)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 7 == 0)
                    result.Add("Buzzinga");
                else
                {
                    string Buzzinga = numbers[i].ToString(); //stage 2
                    int at1 = Buzzinga.IndexOf("53");
                    int at2 = Buzzinga.IndexOf("35");


                    if ((numbers[i] % 3 == 0 && numbers[i] % 5 == 0) || (at1 != -1 || at2 != -1))
                        result.Add("FizzBuzz");
                    else
                    {
                        string help = numbers[i].ToString(); //stage 2
                        int at = help.IndexOf('5');


                        if ((numbers[i] % 5 == 0) || (at != -1))
                            result.Add("Buzz");
                        else if (numbers[i] % 3 == 0)
                            result.Add("Fizz");
                        else
                            result.Add(numbers[i].ToString());
                    }
                }
            }
            return result;
        }
    }
}
