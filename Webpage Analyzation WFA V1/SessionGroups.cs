using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    public class SessionGroups
    {
        WebpageTermTimetable nonLectureSession;
        List<Student> studentGroup;

        public SessionGroups()
        {
            nonLectureSession = new WebpageTermTimetable();
            StudentGroup = new List<Student>();
        }

        public WebpageTermTimetable NonLectureSession
        {
            get
            {
                return nonLectureSession;
            }

            set
            {
                nonLectureSession = value;
            }
        }

        public List<Student> StudentGroup
        {
            get
            {
                return studentGroup;
            }

            set
            {
                studentGroup = value;
            }
        }
    }
}
