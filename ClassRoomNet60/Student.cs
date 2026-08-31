using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel.Design;

public class Student
{
    public string Name { get; }
    public int BirthMonth { get; }
    public int BirthYear { get; }


    public Student(string name, int birthMonth, int birthYear)
    {
        Name = name;
        BirthMonth = birthMonth;
        BirthYear = birthYear;

    }

    public string Season()
    {
        if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
        {
            return "Winter";
        }
        else if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
        {
            return "Spring";
        }
        else if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
        {
            return "Summer";
        }
        else if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
        {
            return "Autumn";
        }
        else return "cant find it";
    }

    

}


