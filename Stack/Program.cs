using System.Collections.Generic;

Stack<int> nums = new Stack<int>();

for(int i = 0; i < 5; i++)
{
    nums.Push(i);
}


Console.WriteLine(nums.Peek());

if(nums.Count > 0)
{
    nums.Pop();
}

Console.WriteLine(nums.Peek());

