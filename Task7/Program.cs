System.Console.WriteLine("* Write 2 number for show ix tablica umnozheniye *");
System.Console.Write("From : ");
int x = int.Parse(Console.ReadLine());
System.Console.Write("To :");
int y = int.Parse(Console.ReadLine());


for (int i = x; i <=y; i++)
{
    System.Console.WriteLine("---------------------");
    for (int j = 1; j <= 10 ; j++)
    {
        System.Console.WriteLine($"{i} * {j} = {i*j}");
    }
}