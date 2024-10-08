package com.fjvieira.aipoweredcoding;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;

import org.junit.jupiter.api.Test;

public class SimpleRuleTest {
    
    @Test
    public void test() {
        SimpleRule simpleRule = new SimpleRule();
        assertArrayEquals(new int[]{1, 2, 3}, simpleRule.execute(new int[]{3, 2, 1}));

    }
}
