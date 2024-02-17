void Sum(int a,char op, int b)
{
    if (op == '+')System.Console.WriteLine($"{a} + {b} = {a+b}"); 

}
void Subtract(int a,char op, int b)
{
    if (op == '-')System.Console.WriteLine($"{a} - {b} = {a-b}"); 

}
void Multiplication(int a,char op, int b)
{
    if (op == '*')System.Console.WriteLine($"{a} * {b} = {a*b}"); 

}
void Division(int a,char op, int b)
{
    if (op == '/')System.Console.WriteLine($"{a} / {b} = {a/b}"); 

}
System.Console.WriteLine("Write your numbers for canculated: ");
System.Console.Write("The first number is:");
int a = int.Parse(Console.ReadLine());
System.Console.Write("The operation is:");
char op = Convert.ToChar(Console.ReadLine());
System.Console.Write("The second number is:");
int b = int.Parse(Console.ReadLine());
Sum(a,op,b);
Subtract(a,op,b);
Multiplication(a,op,b);
Division(a,op,b);

