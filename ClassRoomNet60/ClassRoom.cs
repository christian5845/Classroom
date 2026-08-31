using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ClassRoom
{
    public string ClassName { get; }
    public List<Student> StudentList { get; set; }
    public DateTime SemesterStart { get; private set; }

    public ClassRoom(string className, DateTime semesterStart)
    {
        ClassName = className;
        StudentList = new List<Student>();
        SemesterStart = new();
    }

    public void WhatSeason()
    {
        var result = StudentList.GroupBy(x => x.Season())
            .Select(periodTime => new
            {
                period = periodTime.Key,
                countperiod = periodTime.Count()
            });

        foreach (var item in result)
        {
            Console.WriteLine($"Season: {item.period} Count: {item.countperiod} ");

        }
    }
}


    

