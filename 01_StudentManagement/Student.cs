
namespace Student;
internal class Student
{
    public string Name { get; set; }

    public string Surname { get; set; }
    public int Age { get; set; }

    public int[] Scores { get; set; }

    public Student(string name,string surname,int age)
    {
        Name = name;
        Surname = surname;
        Age = age;

    }

    public double CalculateAverage()
    {
        if (Scores == null || Scores.Length == 0)
            throw new Exception("Scores bosdur!");
        int Sum = 0;
        foreach (int score in Scores)
        {
            if (score < 0 || score > 100)
            {
                throw new Exception("bal duzgun deyil!");
            }
            Sum += score;
        }
        return (double)Sum / Scores.Length;
    }


}