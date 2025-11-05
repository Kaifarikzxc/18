using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public int AdmissionYear { get; set; }
    public int Course { get; set; }
    public string Group { get; set; }
    public List<int> Grades { get; set; }

    // Оптимизация: среднего балла
    public double AverageGrade { get; set; }

    public void CalculateAverage()
    {
        AverageGrade = Grades.Average();
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = CreateStudents();

        // Предварительно вычисление средний балл каждого студента
        foreach (var student in students)
            student.CalculateAverage();

        // Вывод исходного списка
        Console.WriteLine("Список студентов (без сортировки):\n");
        PrintStudents(students);

        // Запрос пользователя на сортировку
        Console.WriteLine("\nХотите отсортировать студентов по среднему баллу? (д/н): ");
        string choice = Console.ReadLine()?.Trim().ToLower();

        if (choice == "д" || choice == "y")
        {
            var sorted = students.OrderByDescending(s => s.AverageGrade).ToList();
            Console.WriteLine("\nСписок студентов, отсортированных по среднему баллу:\n");
            PrintStudents(sorted);
        }
        else
        {
            Console.WriteLine("\nСортировка не выполнена. Программа завершена.");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static List<Student> CreateStudents()
    {
        return new List<Student>
        {
            new Student { Name="Иванов Иван", BirthDate=new DateTime(2005,1,12), AdmissionYear=2021, Course=3, Group="31", Grades=new List<int>{8,9,7,10}},
            new Student { Name="Петров Петр", BirthDate=new DateTime(2004,9,3), AdmissionYear=2020, Course=4, Group="41", Grades=new List<int>{9,9,10,8}},
            new Student { Name="Сидорова Анна", BirthDate=new DateTime(2005,2,22), AdmissionYear=2021, Course=3, Group="31", Grades=new List<int>{10,10,9,10}},
            new Student { Name="Кузнецов Дмитрий", BirthDate=new DateTime(2005,5,14), AdmissionYear=2021, Course=3, Group="32", Grades=new List<int>{7,8,7,9}},
            new Student { Name="Орлова Елена", BirthDate=new DateTime(2006,6,11), AdmissionYear=2022, Course=2, Group="21", Grades=new List<int>{9,10,10,10}},
            new Student { Name="Фёдоров Алексей", BirthDate=new DateTime(2004,8,19), AdmissionYear=2020, Course=4, Group="41", Grades=new List<int>{8,8,9,7}},
            new Student { Name="Морозова Ольга", BirthDate=new DateTime(2005,3,15), AdmissionYear=2021, Course=3, Group="31", Grades=new List<int>{10,9,9,10}},
            new Student { Name="Николаев Сергей", BirthDate=new DateTime(2006,4,10), AdmissionYear=2022, Course=2, Group="22", Grades=new List<int>{7,8,8,7}},
            new Student { Name="Васильева Мария", BirthDate=new DateTime(2004,12,1), AdmissionYear=2020, Course=4, Group="42", Grades=new List<int>{9,9,8,9}},
            new Student { Name="Попов Андрей", BirthDate=new DateTime(2005,7,9), AdmissionYear=2021, Course=3, Group="33", Grades=new List<int>{8,9,9,8}},
            new Student { Name="Соколова Дарья", BirthDate=new DateTime(2005,5,30), AdmissionYear=2021, Course=3, Group="31", Grades=new List<int>{10,10,10,9}},
            new Student { Name="Алексеев Павел", BirthDate=new DateTime(2006,2,18), AdmissionYear=2022, Course=2, Group="21", Grades=new List<int>{8,8,9,9}},
            new Student { Name="Беляева Виктория", BirthDate=new DateTime(2004,11,25), AdmissionYear=2020, Course=4, Group="41", Grades=new List<int>{9,10,9,9}},
            new Student { Name="Егоров Максим", BirthDate=new DateTime(2005,8,5), AdmissionYear=2021, Course=3, Group="33", Grades=new List<int>{7,8,8,8}},
            new Student { Name="Дмитриева Ирина", BirthDate=new DateTime(2006,1,14), AdmissionYear=2022, Course=2, Group="22", Grades=new List<int>{9,10,10,9}},
            new Student { Name="Григорьев Олег", BirthDate=new DateTime(2005,3,7), AdmissionYear=2021, Course=3, Group="31", Grades=new List<int>{8,7,8,9}},
            new Student { Name="Киселева Наталья", BirthDate=new DateTime(2005,10,17), AdmissionYear=2021, Course=3, Group="32", Grades=new List<int>{10,9,10,10}},
            new Student { Name="Макаров Артём", BirthDate=new DateTime(2004,4,8), AdmissionYear=2020, Course=4, Group="42", Grades=new List<int>{9,9,8,9}},
            new Student { Name="Зайцева Алина", BirthDate=new DateTime(2006,3,21), AdmissionYear=2022, Course=2, Group="21", Grades=new List<int>{9,8,10,9}},
            new Student { Name="Тихонов Иван", BirthDate=new DateTime(2005,9,29), AdmissionYear=2021, Course=3, Group="31", Grades=new List<int>{7,7,8,8}},
            new Student { Name="Семенова Мария", BirthDate=new DateTime(2004,7,2), AdmissionYear=2020, Course=4, Group="41", Grades=new List<int>{9,10,10,9}},
            new Student { Name="Фомин Денис", BirthDate=new DateTime(2006,5,16), AdmissionYear=2022, Course=2, Group="22", Grades=new List<int>{8,8,9,9}},
            new Student { Name="Ковалёва Софья", BirthDate=new DateTime(2005,6,26), AdmissionYear=2021, Course=3, Group="32", Grades=new List<int>{9,9,10,9}},
            new Student { Name="Романов Степан", BirthDate=new DateTime(2006,2,4), AdmissionYear=2022, Course=2, Group="21", Grades=new List<int>{7,8,8,8}},
            new Student { Name="Чернова Лидия", BirthDate=new DateTime(2005,11,13), AdmissionYear=2021, Course=3, Group="33", Grades=new List<int>{10,9,9,10}}
        };
    }

    static void PrintStudents(List<Student> students)
    {
        Console.WriteLine($"{"ФИО",-22} {"Группа",-6} {"Курс",-4} {"Средний балл",-14}");
        Console.WriteLine(new string('-', 55));

        foreach (var s in students)
        {
            Console.WriteLine($"{s.Name,-22} {s.Group,-6} {s.Course,-4} {s.AverageGrade:F2}");
        }
    }
}
