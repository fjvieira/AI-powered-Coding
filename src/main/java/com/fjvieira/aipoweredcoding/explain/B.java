package com.fjvieira.aipoweredcoding.explain;

import java.util.HashMap;
import java.util.Map;

public class B {

    public static int solution(int[] a) {
        int edge = a.length / 2;

        Map<Integer, Integer> frequency = new HashMap<>();

        for (int i = 0; i < a.length; i++) {
            int freqNumber = frequency.containsKey(a[i]) ? frequency.get(a[i]) + 1 : 1;
            frequency.put(a[i], freqNumber);
            if (freqNumber > edge)
                return i;

        }

        return -1;
    }
}
