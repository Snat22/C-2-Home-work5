int even = 0;
int EvenCount(int n)
{
    for (int i = n; i > 0; i/=10)
    {
       if (i%2==0)even++;
    }
    return even;
}


int odd = 0;
int OddCount(int n)
{
    for (int i = n; i > 0; i/=10)
    {
       if (i%2!=0)odd++;
    }
    return odd;
}


int zero = 0;
int ZeroCount(int n)
{
    for (int i = n; i > 0; i/=10)
    {
        if(i%10==0)zero++;
    }
    return zero;
}

int digit = 0;
int DigitCount(int n)
{
    for (int i = n; i > 0; i/=10)
    {
       digit++;
    }
    return digit;
}

int min = 0;
int MinCount(int n)
{
    for (int i = n; i > 0 ; i/=10)
    {
        if (i%10<0)
        min++;
    }
    return min;
}

int max = 0;
int MaxCount(int n)
{
    for (int i = n; i > 0 ; i/=10)
    {
        if (i%10>0)
        max++;
    }
    return max;
}
int sum = 0;
int SumOfDigits(int n)
{
    for (int i = n; i > 0 ; i/=10)
    {
        sum += i%10;
        
    }
    return sum;
}
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Even: {EvenCount(n)}");
System.Console.WriteLine($"Odd: {OddCount(n)}");
System.Console.WriteLine($"Zeros: {ZeroCount(n)}");
System.Console.WriteLine($"Digits: {DigitCount(n)}");
System.Console.WriteLine($"Min: {MinCount(n)}");
System.Console.WriteLine($"Max: {MaxCount(n)}");
System.Console.WriteLine($"Sum of Digits: {SumOfDigits(n)}");

EvenCount(even);
OddCount(odd);
ZeroCount(zero);
DigitCount(digit);
