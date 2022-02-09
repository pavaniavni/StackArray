using System;

public class StackArrays
{
    public static void Main(string[] args)
    {
        int size = 2;
        Stack stack = new Stack(size);

        int s1 = int.Parse(Console.ReadLine());
         int s2 = int.Parse(Console.ReadLine());

        stack.Push(s1);
        stack.Push(s2);

        s1 = stack.Pop();
        s2 = stack.Pop();

        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}

public class Stack
{
    private int[] stack;
    private int position;

    public Stack(int size)
    {
        position = 0;
        stack = new int[size];
    }

    public void Push(int value)
    {
        stack[position] = value;
        position++;
    }

    public int Pop()
    {
        if (position > 0)
        {
            position -= 1;
            return stack[position];
        }
        return 0;
    }
}