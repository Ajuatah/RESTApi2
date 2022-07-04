using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTApi2.Models
{
    public class StudentDemoData
    {
        public int RollNum { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

    }

    public class StudentDataList
    {
        public List<StudentDemoData> studentDemoDatas { get; set; }

        public StudentDataList()
        {
            studentDemoDatas = new List<StudentDemoData>();
            StudentDemoData sd = new StudentDemoData();
            sd.RollNum = 1001;
            sd.Name = "Biology";
            sd.Course = "BIO 201";
            studentDemoDatas.Add(sd);

            sd.RollNum = 1002;
            sd.Name = "MAths";
            sd.Course = "MATH 201";
            studentDemoDatas.Add(sd);

            sd.RollNum = 1003;
            sd.Name = "Chmistry";
            sd.Course = "CHM  201";
            studentDemoDatas.Add(sd);
        }
    }
}