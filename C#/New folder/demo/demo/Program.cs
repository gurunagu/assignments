using System;
using System.Collections;
using System.Collections.Generic;

public class UnSafeCast
{
    public static void Main()
    {
        GenList<dynamic> obj = new GenList<dynamic>();

        obj.AddVal("yoo");
        obj.AddVal("hi");
        obj.AddVal(2);
        obj.AddVal(3.3);

        Console.WriteLine(obj.count);

        obj.Display();

        Console.ReadLine();
    }
}
class GenList<T>
{
    public int count = -1;
    private const int Max = 20;
    public T[] Node = new T[Max];

    public void AddVal(T value)
    {
        count = count + 1;
        Node[count] = value;
    }

    public void Display()
    {
        IEnumerable<T> IEnum = Node;
        if (count == -1)
        {
            Console.WriteLine("List is Empty");
        }
        else
        {
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine("Node[" + i + "] = " + Node[i]);
            }
        }
    }

    public void Clear()
    {
        count = -1;
    }
}