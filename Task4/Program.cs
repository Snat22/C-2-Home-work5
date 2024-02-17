int n = int.Parse(Console.ReadLine());

int [] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    if (i%2==0) System.Console.Write(arr[i]+" ");
}