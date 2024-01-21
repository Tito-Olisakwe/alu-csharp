class Program
{
    static void Main()
    {
        LinkedList<int> myLinkedList = new LinkedList<int>();

        // Adding some elements to the LinkedList
        myLinkedList.AddLast(91);
        myLinkedList.AddLast(-22);
        myLinkedList.AddLast(13);
        myLinkedList.AddLast(14);
        myLinkedList.AddLast(-54);
        myLinkedList.AddLast(66);
        myLinkedList.AddLast(37);
        myLinkedList.AddLast(-8);

        // Trying to get the value of node at different positions
        Console.WriteLine("Value at index 5: " + LList.GetNode(myLinkedList, 5));
        Console.WriteLine("Value at index 0: " + LList.GetNode(myLinkedList, 0));
        Console.WriteLine("Value at index 10 (non-existent): " + LList.GetNode(myLinkedList, 10));
    }
}
