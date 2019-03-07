
import java.util.ArrayList;

class Stack {

    private final ArrayList<Integer> myStack = new ArrayList<Integer>();
    
    public void push(int number) {
        myStack.add(number);
    }

    public String toString() {
    	
        String output = "";

        for (Integer count : myStack) {
            output += count + "\n";
        }
        return output.toString();
    }

}