namespace Student;

internal class Program
{
    static void Main(string[] args)
    {
        //Task 1.Student classı yaradın: 
        //Name, Surname, Age, Scores[] (imtahan balları üçün array) propları olsun.Constructor ilə Name, Surname, Age təyin edin.
        //CalculateAverage() metodu yazın — loop ilə ortalama hesablasın. Əgər ballardan biri 0–100 aralığında deyilsə exception atın.
        //Main - də 5 tələbə yaradın, ortalamaları ekrana çıxarın və ən yüksək ortalamalı tələbəni tapın.

        Student stu1 = new Student("Murad", "Aliyev", 19);
        Student stu2 = new Student("Nigar", "Hasanova", 20);
        Student stu3 = new Student("Elvin", "Memmedov", 21);
        Student stu4 = new Student("Aysel", "Huseynova", 18);
        Student stu5 = new Student("Orxan", "Quliyev", 22);


        stu1.Scores = [60, 70, 80, 90, 78];
        stu2.Scores = [85, 90, 75, 80, 95];
        stu3.Scores = [70, 65, 80, 75, 90];
        stu4.Scores = [95, 90, 100, 85, 90];
        stu5.Scores = [60, 70, 75, 80, 85];

        List<Student> students = new List<Student>()
        {
            stu1,
            stu2,
            stu3,
            stu4,
            stu5
        };


        Student maxStudent = students[0];
        foreach (Student student in students)
        {

            if (student.CalculateAverage() > maxStudent.CalculateAverage())
            {
                maxStudent = student;
            }


          
        }

        Console.WriteLine($"MAx average:{maxStudent.Name} {maxStudent.Surname}");
        Console.WriteLine($"average:{maxStudent.CalculateAverage()}");

        foreach(Student student in students)
        {
            Console.WriteLine($"Student average:{student.CalculateAverage()}");
        }
    }
}
