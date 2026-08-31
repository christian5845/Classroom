using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

public class Student
{
    public string Name { get; }
    public int BirthMonth { get; }
    public int BirthYear { get; }


    public Student (string name, int birthMonth, int birthYear)
    {
        Name = name;
        BirthMonth = birthMonth;
        BirthYear = birthYear;

    }
}

