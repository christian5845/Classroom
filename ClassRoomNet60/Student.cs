using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public string Name { get; private set; }
    public int BirthMonth { get; private set; }
    public int BirthYear { get; private set; }


    public Student (string name, int birthMonth, int birthYear)
    {
        name = Name;
        birthMonth = BirthMonth;
        birthYear = BirthYear;

    }
}

