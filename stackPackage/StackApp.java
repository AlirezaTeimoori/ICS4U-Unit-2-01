package stackPackage;

import java.util.Stack;

class StackApp {
    public static void main(String[] args) {
        Stack<Integer> stack = new Stack<Integer>();
        stack.push(88);
        stack.push(21);
        System.out.println(stack.toString());
    }
}