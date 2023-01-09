using System.Collections;

ArrayList myArrayList = new ArrayList();

myArrayList.Add(25);
myArrayList.Add("Hello");
myArrayList.Add(22);
myArrayList.Add(13.65);
myArrayList.Add(59);
myArrayList.Add(78);
myArrayList.Add(63);
myArrayList.Add(77);
myArrayList.Add(33);


Console.WriteLine("Initial Length of ArrayList is {0}", myArrayList.Count);

myArrayList.RemoveAt(0);

myArrayList.Remove(78);

double sum = 0;

foreach(object obj in myArrayList)
{
    if(obj is int)
    {
        sum += Convert.ToDouble(obj);
    }
    else if(obj is double)
    {
        sum += (double)obj;
    }
    else
    {
        Console.WriteLine(obj.ToString());
    }
}
Console.WriteLine("Sum of ArrayList is {0}", sum);

Console.ReadLine();