using System;
using System.Collections.Generic;

namespace com.fjvieira.aipoweredcoding.explain
{
    public class B
    {
        public static int Solution(int[] a)
        {
            int edge = a.Length / 2;

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                int freqNumber = frequency.ContainsKey(a[i]) ? frequency[a[i]] + 1 : 1;
                frequency[a[i]] = freqNumber;
                if (freqNumber > edge)
                    return i;
            }

            return -1;
        }
    }
}