using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ClassRoom
{
    public string CLassName { get; }
    public List<Student> StudentList { get; set; }
    public DateTime SemesterStart { get; private set; }

    public ClassRoom(string className, DateTime semesterstart)
    {
        className = className;
        StudentList = new List<Student>();
        semesterstart = new ();
    }


}
    

