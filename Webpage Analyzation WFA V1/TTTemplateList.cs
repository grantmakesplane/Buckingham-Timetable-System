using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    public class TTTemplateList
    {
        List<WebpageTermTimetable> tttemPlateList;
        List<Student> studentList;

        public TTTemplateList()
        {
            TttemPlateList = new List<WebpageTermTimetable>();
            StudentList = new List<Student>();
        }

        public List<WebpageTermTimetable> TttemPlateList
        {
            get
            {
                return tttemPlateList;
            }

            set
            {
                tttemPlateList = value;
            }
        }

        public List<Student> StudentList
        {
            get
            {
                return studentList;
            }

            set
            {
                studentList = value;
            }
        }
    }
}
