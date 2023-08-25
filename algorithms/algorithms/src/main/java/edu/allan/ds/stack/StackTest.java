package edu.allan.ds.stack;

public class StackTest {

    public static void main(String[] args){

        Stack stack = new Stack(3);
        stack.push(2);
        stack.push(3);
        stack.push(2);
        stack.pop();
        stack.pop();
        stack.pop();
        stack.pop();
        stack.push(2);
        stack.push(3);
        stack.push(2);
        stack.push(10);

        stack.printStack();
    }


}
