// See https://aka.ms/new-console-template for more information
using System;

ClassRoom Klasse = new ClassRoom("4a", new DateTime(2026, 8, 20));
Student Søren = new Student("Søren", 3, 1950);
Student Rasmus = new Student("Rasmus", 3, 2004);
Klasse.StudentList.Add(Søren);
Klasse.StudentList.Add(Rasmus);

foreach (var student in Klasse.StudentList)
{
    Console.WriteLine(student.BirthYear);
}
