using System;
using System.Collections.Generic;

var numbers = new int[10] { 23, 2, 24, 4, 10, 17 ,56 ,7, 78, 11 };
var header = new Node();

var list = new LinkedListInput(header);
var ant = header;

foreach (var character in numbers)
{
    var node = new Node
    {
        Data = character,
        Prev = ant
    };

    ant.Next = node;
    ant = node;
}

list.OrderListBubbleAlgoritm();
list.Print();

public class Node
{
    public int Data;
    public Node? Next;
    public Node? Prev;
};

class LinkedListInput
{
    public Node Head;

    public LinkedListInput(Node head) => Head = head;

    public void OrderListBubbleAlgoritm()
    {
        if (Head == null)
            return;

        int temp;
        bool needRestart;
        do
        {
            needRestart = false;
            var actualNode = Head;
            while (!needRestart && actualNode.Next != null)
            {
                if (actualNode.Next.Data >= actualNode.Data)
                    actualNode = actualNode.Next;
                else
                {
                    temp = actualNode.Data;
                    actualNode.Data = actualNode.Next.Data;
                    actualNode.Next.Data = temp;

                    needRestart = true;
                }
            }
        }
        while (needRestart);
    }

    public void Print()
    {

        var list = new List<int>();
        while (Head != null)
        {
            list.Add(Head.Data);
            Head = Head.Next;
        }

        Console.WriteLine(string.Join(", ", list));
    }
};