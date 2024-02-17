int n = int.Parse(Console.ReadLine());
int [] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int zero = 0,negative = 0,positive = 0,even =0,odd= 0,sum=0;
int max = arr[0];
int min = arr[0];
for (int i = 0 ; i<arr.Length ;i++)
{
    if (arr[i]>max) max = arr[i];
    if (arr[i]<min) min = arr[i];
    if (arr[i]==0)zero++;
    if (arr[i]<0)negative++;
    if (arr[i]>0)positive++;
    if (arr[i]%2==0)even++;
    if (arr[i]%2!=0)odd++;
    sum += arr[i];

}
System.Console.WriteLine($"Zero: {zero}");
System.Console.WriteLine($"Negative: {negative}");
System.Console.WriteLine($"Positive:{positive}");
System.Console.WriteLine($"Even: {even}");
System.Console.WriteLine($"Odd: {odd}");
System.Console.WriteLine($"Sum of digits {sum}");
System.Console.WriteLine(max);
System.Console.WriteLine(min);
