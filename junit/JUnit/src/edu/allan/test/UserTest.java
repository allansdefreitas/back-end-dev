package edu.allan.test;

import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import edu.allan.Calculator;
import edu.allan.model.User;

class UserTest {

	private User user;
	
	@BeforeEach
	public void createUser() {
		this.user = new User("John", 28);
		System.out.println("@BeforeEach");
	}
	
	@AfterEach
	public void emptyUser() {
		this.user = new User();
		System.out.println("@AfterEach");
	}
	
	// Must be static
	@BeforeAll
	public static void beforeAll() {
		
		System.out.println("@BeforeAll");
	}

	// Must be static
	@AfterAll
	public static void afterAll() {
		System.out.println("@AfterAll");
	}
	
	@Test
	void SumTest() {
		
		int sum = Calculator.sum(1, 1);
		
		Assertions.assertEquals(2, sum);
		System.out.println("Test");
	}

}
