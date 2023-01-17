// See https://aka.ms/new-console-template for more information

var arr = new List<int>();

arr.Add(6);
arr.Add(6);
arr.Add(6);
arr.Add(2);
arr.Add(2);
arr.Add(3);
arr.Add(1);
arr.Add(4);
arr.Add(2);
arr.Add(3);
arr.Add(7);
arr.Add(3);
arr.Add(6);
arr.Add(2);
arr.Add(6);
arr.Add(2);

static int migratoryBirds(List<int> arr)
{
    var myHash = new Dictionary<int, int>();

    for (int i = 0; i < arr.Count; i++)
    {
        if (!myHash.ContainsKey(arr[i]))
        {
            myHash.Add(arr[i], 1);
        }
        else
        {
            myHash[arr[i]] += 1;
        }
    }

    var maxValue = myHash.Values.Max();
    Console.WriteLine($"Max Value is: {maxValue}");

    var stack = new Stack<int>();

    foreach (var item in myHash)
    {
        if (maxValue == item.Value)
        {
            stack.Push(item.Key);
            Console.WriteLine(item.Key);
        }
    }
    var min = stack.Min();
    Console.WriteLine($"The min is: {min}");
    return min;
}


Console.WriteLine($"The answer is: {migratoryBirds(arr)}");

