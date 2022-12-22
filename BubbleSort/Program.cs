int[] arr = { 85, 45, 58, 12, 28, 2, 77, 99, 105, 65 };

for(int i = 0; i < arr.Length; i++)
{
    for(int j = 0; j < arr.Length; j++)
    {
        if (arr[i] < arr[j])
        {
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}
for(int k = 0; k < arr.Length; k++)
{
    Console.WriteLine(arr[k]);
}
Console.ReadLine();

