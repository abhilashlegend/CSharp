Queue<int> queue = new Queue<int>();

//printing the element at the front of the queue
queue.Enqueue(1);
Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
queue.Enqueue(2);
Console.WriteLine("Top value in the queue is : {0}", queue.Peek());
queue.Enqueue(3);
Console.WriteLine("Top value in the queue is : {0}", queue.Peek());

while(queue.Count > 0)
{
    // Dequeue() will return the element that was removed from the queue
    Console.WriteLine("The front value {0} was removed from the queue", queue.Dequeue());

    //Print the queue count
    Console.WriteLine("Current queue count is {0}", queue.Count);

}

