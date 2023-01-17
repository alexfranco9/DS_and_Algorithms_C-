// See https://aka.ms/new-console-template for more information


/*
 * Complete the 'divisibleSumPairs' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts following parameters:
 *  1. INTEGER n
 *  2. INTEGER k
 *  3. INTEGER_ARRAY ar
 */

int n = 6;
int k = 3;

var ar = new List<int>();

ar.Add(1);
ar.Add(3);
ar.Add(2);
ar.Add(6);
ar.Add(1);
ar.Add(2);


static int divisibleSumPairs(int n, int k, List<int> ar)
{
    int validPairs = 0;

    for (int i = 0; i < ar.Count; i++)
    {
        for (int j = i + 1; j < ar.Count; j++)
        {
            if (((ar[i] + ar[j]) % k) == 0)
            {
                validPairs++;
            }
        }
    }
    return validPairs;
}

Console.WriteLine(divisibleSumPairs(n, k, ar));












