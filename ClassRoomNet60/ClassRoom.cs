using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ClassRoom
{
    public string CLassName { get; }
    public List<Student> StudentList { get; set; }
    public DateTime SemesterStart { get; }

    public ClassRoom(string className, List<Student> studentList, DateTime semesterStart)
    {
        className = className;
        studentList = new List<Student>();
        semesterStart = SemesterStart;
    }


}
    

