package edu.allan.test;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import edu.allan.model.Calculator;

class CalculatorTest {

	@Test
	void SumTest() {
		
		int sum = Calculator.sum(1, 1);
		
		Assertions.assertEquals(2, sum);
	}

}
