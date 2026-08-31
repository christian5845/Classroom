// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ClassRoom Klasse = new ClassRoom("4a", new DateTime (2026/8/20));
Student Søren = new Student("Søren", 03, 1950);
Student Rasmus = new Student("Rasmus", 03, 2004);
Klasse.StudentList.Add(Søren);
Klasse.StudentList.Add(Rasmus);
