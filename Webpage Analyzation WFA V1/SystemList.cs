using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    public static class SystemList   // SystemLists
    {
        private static List<Student> studentList = new List<Student> ();   // StudentList
        private static List<Lecturer> lecturerList = new List<Lecturer>(); //LecturerList 
        private static List<Room> roomsList = new List<Room>();         //RoomList
        private static List<Module> moduleList = new List<Module>();    //ModuleList
        private static List<WebpageTermTimetable> termTimetableList = new List<WebpageTermTimetable>(); // TermTimetableList
        private static List<SessionGroups> sessionGroupList = new List<SessionGroups>();
        private static List<TTTemplateList> templateList = new List<TTTemplateList>();

        internal static List<Student> StudentList
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

        internal static List<Lecturer> LecturerList
        {
            get
            {
                return lecturerList;
            }

            set
            {
                lecturerList = value;
            }
        }

        internal static List<Room> RoomsList
        {
            get
            {
                return roomsList;
            }

            set
            {
                roomsList = value;
            }
        }

        internal static List<Module> ModuleList
        {
            get
            {
                return moduleList;
            }

            set
            {
                moduleList = value;
            }
        }

        public static List<WebpageTermTimetable> TermTimetableList
        {
            get
            {
                return termTimetableList;
            }

            set
            {
                termTimetableList = value;
            }
        }

        

        internal static List<SessionGroups> SessionGroupList
        {
            get
            {
                return sessionGroupList;
            }

            set
            {
                sessionGroupList = value;
            }
        }

        internal static List<TTTemplateList> TemplateList
        {
            get
            {
                return templateList;
            }

            set
            {
                templateList = value;
            }
        }
    }
}
