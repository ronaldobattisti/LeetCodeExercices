using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class Roman_To_Integer
    {
        Dictionary<char, int> conversion = new() 
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

        public int RomanToInteger(string romanValue) {
            List<int> intValue = new List<int>();
            List<int> section = new List<int>();
            int trimIndex = 0;
            int sum = 0;
            foreach(char item in romanValue)
            {
                intValue.Add(conversion[item]);
            }

            while(intValue.Count > 0)
            {
                trimIndex = nextBiggerNumber(intValue);
                if(trimIndex != 0) { 
                    section = intValue.GetRange(0, trimIndex + 1);
                    intValue.RemoveRange(0, trimIndex + 1);
                    sum += convertSection(section);
                } else {
                    sum += intValue[0];
                    intValue.RemoveAt(0);
                }
            }
            Console.WriteLine($"Sum is {sum}");
            return sum;
        }

        private int nextBiggerNumber(List<int> numbers)
        {
            int number = numbers[0];
            int index = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > number)
                {
                    index = i;
                    return index;
                }
            }
            return index;
        }

        private int convertSection(List<int> section)
        {
            int cont = section.Count;
            int total = section[section.Count-1];
            for (int i = section.Count - 2; i >= 0; i--)
            {
                total -= section[i];
            }
            return total;
        }
    }
}
