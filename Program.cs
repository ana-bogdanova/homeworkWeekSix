using System;

class Program
{
    static void Main()
    {
        Program program = new Program();

        int[] gradesStudentOne = { 9, 8, 9, 7, 10 };
        int[] gradesStudentTwo = { 10, 9, 10, 9, 10 };
        int[] gradesStudentThree = { 3, 4, 6, 7, 2 };
        int[] gradesStudentFour = { 1, 2, 0, 0, 3 };
        int[] gradesStudentFive = { 3, 4, 6, 7, 9 };

        // Shows information about average student grade and missed lessons if there are any


        Console.WriteLine("Student One Grades Info:");
        program.missedAndLowGrades(gradesStudentOne);
        Console.WriteLine($"Average grade: {program.averageStudentGrade(gradesStudentOne)}");
        Console.WriteLine();

        Console.WriteLine("Student Two Grades Info:");
        program.missedAndLowGrades(gradesStudentTwo);
        Console.WriteLine($"Average grade: {program.averageStudentGrade(gradesStudentTwo)}");
        Console.WriteLine();

        Console.WriteLine("Student Three Grades Info:");
        program.missedAndLowGrades(gradesStudentThree);
        Console.WriteLine($"Average grade: {program.averageStudentGrade(gradesStudentThree)}");
        Console.WriteLine();

        Console.WriteLine("Student Four Grades Info:");
        program.missedAndLowGrades(gradesStudentFour);
        Console.WriteLine($"Average grade: {program.averageStudentGrade(gradesStudentFour)}");
        Console.WriteLine();

        Console.WriteLine("Student Five Grades Info:");
        program.missedAndLowGrades(gradesStudentFive);
        Console.WriteLine($"Average grade: {program.averageStudentGrade(gradesStudentFive)}");    
        Console.WriteLine(); 
    }
    void missedAndLowGrades(int [] studentGrades)
    {
        for (int i = 0; i < studentGrades.Length; i++)
        {
            int weekNumber = i + 1;
            if (studentGrades[i] == 0)
            {
                Console.WriteLine($"Missed lesson on week {weekNumber}");
            }
            else if (studentGrades[i] < 5)
            {
                Console.WriteLine ($"Lesson grade on week {weekNumber} has a low grade of {studentGrades[i]}");
            }

        }

    }

int averageStudentGrade(int[] studentGrades)
{
    int sum = 0;
    for (int i = 0; i < studentGrades.Length; i++)
    {
        sum += studentGrades[i];
    }
    return sum/studentGrades.Length;
}

}