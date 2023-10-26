package edu.allan.ds.stack;

public class Stack {

    private static final int VOID_STACK_INDICATOR = -1;
    private static final int VOID_POSITION_INDICATOR = 0;
    private static final int FIRST_POSITION_STACK = 0;
    private int[] stack;
    private int currentPosition;
    private int stackSize = 0;

    public Stack(int size){
        this.stackSize = size;
        this.stack = new int[this.stackSize];
        this.currentPosition = FIRST_POSITION_STACK;
    }

    public void push(int value){
        controlStackBounds();
        if ( allowPushToStack() ){
            pushToStack(value);
        }
    }

    public int pop(){
        controlStackBounds();

        int removedElement = VOID_POSITION_INDICATOR;

        if( allowPopFromStack() ){
            removedElement = getIthPositionStack(this.currentPosition);
            removeFromPosition(this.currentPosition);
        }
        return removedElement;
    }

    public void printStack(){

        int ithValue;
        for (int i = 0; i < this.stackSize; i++){
            ithValue = this.getIthPositionStack(i);
            System.out.print(ithValue + " ");
        }
    }

//    private boolean

    private int getIthPositionStack(int position){
        int ithPositionValue = this.stack[position];
        return ithPositionValue;
    }

    private void removeFromPosition(int position){
        setIthPositionStack(position, VOID_POSITION_INDICATOR);
        this.currentPosition--;
    }

    private void setIthPositionStack(int position, int value){
        this.stack[position] = value;
    }

    private void pushToStack(int value){
        setIthPositionStack(this.currentPosition, value);
        this.currentPosition++;
    }
    private boolean allowPushToStack() {

        if(this.currentPosition == this.stackSize){
            return false;
        }else{
            return true;
        }
    }

    private boolean allowPopFromStack(){

        if(this.currentPosition == VOID_STACK_INDICATOR){
            return false;
        }else{
            return true;
        }
    }

    private void controlBottomBound(){
        if(currentPosition < 0){
            this.currentPosition = 0;
        }
    }

    private void controlTopBound(){
        if(this.currentPosition >= this.stackSize){
            this.currentPosition = this.stackSize - 1;
        }
    }

    private void controlStackBounds(){
        this.controlBottomBound();
        this.controlTopBound();
    }

}
