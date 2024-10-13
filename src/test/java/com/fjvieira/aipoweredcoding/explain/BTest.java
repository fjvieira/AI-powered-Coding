package com.fjvieira.aipoweredcoding.explain;

import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.jupiter.api.Test;

public class BTest {
    
    @Test
    public void testSolution() {
        assertEquals(-1, B.solution(new int[] { }));
        assertEquals(0, B.solution(new int[] { 11 }));
        assertEquals(-1, B.solution(new int[] { 1, 0 }));
        assertEquals(1, B.solution(new int[] { 1, 1, 1 }));
        assertEquals(-1, B.solution(new int[] { 0, 0, 0, 1, 1, 1 }));
        assertEquals(7, B.solution(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 }));
        assertEquals(8, B.solution(new int[] { 0, 0, 0, 0, 1, 1, 1, 1, 1 }));
        assertEquals(-1, B.solution(new int[] { 0, 0, 0, 0, 1, 1, 1, 1 }));
        assertEquals(-1, B.solution(new int[] { 0, 0, 0, 0, 2, 1, 1, 1, 1 }));
    }
 
}
