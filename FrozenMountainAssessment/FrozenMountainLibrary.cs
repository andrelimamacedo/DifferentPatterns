using System;
using System.Collections.Generic;

namespace FrozenMountainAssessment
{
    /// <summary>
    /// This lib finds all the different patterns in "input" of length "patternLength"
    /// and return a list of  all of the patterns that occur more than once and the number of times they occur
	/// by Andre Lima Macedo - andrelimamacedo@hotmail.com
    /// </summary>
    public class FrozenMountainLibrary
    {
        public List<KeyValuePair<string, int>> getResult(Dictionary<string, int> dic)
        {
            List<KeyValuePair<string, int>> result = new List<KeyValuePair<string, int>>();
            foreach (KeyValuePair<string, int> entry in dic)
            {
                if (entry.Value > 1)
                {
                    result.Add(new KeyValuePair<string, int>(entry.Key, entry.Value));
                }
            }
            return result;

        }

        public List<KeyValuePair<string, int>> getDifferentPatterns(string input, int length)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            if (length > (input.Length - 1) || (length <= 0))
            {
                return new List<KeyValuePair<string, int>>();
            }
            int index = 0;
            string subString = "";
            while (index <= (input.Length - length))
            {
                subString = input.Substring(index, length);                
                if (!dic.ContainsKey(subString))
                {
                    dic.Add(subString, 1);
                }
                else
                {
                    dic[subString]++;
                }
                index++;
            }
            return getResult(dic);
        }
    }
}
