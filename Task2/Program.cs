char ChekGrade(int grade)
{
    if (grade > 90 && grade <= 100) grade ='A';
    if (grade >= 80 && grade < 89)  grade ='B';
    if (grade >= 70 && grade < 79)  grade ='C';

    if (grade >= 60 && grade < 69)  grade ='D';
    if (grade >= 0 && grade < 59)  grade = 'F';
    else
    {
        System.Console.WriteLine("Write Correct grade :");
    }

    return (char)grade;
    
}

int gr = int.Parse(Console.ReadLine());

ChekGrade(gr);
System.Console.WriteLine(ChekGrade(gr));