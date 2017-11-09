using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    public class WebpageTermTimetable
    {
        private string moduleFullName;
        private string moduleShortName;
        private string sessinonProperty;
        private int day;
        private int startHour;
        private int startMin;
        private int endHour;
        private int endMin;
        private int lecturerID;
        private string roomName;
        private int roomSize;

        public int StartHour
        {
            get
            {
                return startHour;
            }

            set
            {
                startHour = value;
            }
        }

        public int StartMin
        {
            get
            {
                return startMin;
            }

            set
            {
                startMin = value;
            }
        }

        public int EndHour
        {
            get
            {
                return endHour;
            }

            set
            {
                endHour = value;
            }
        }

        public int EndMin
        {
            get
            {
                return endMin;
            }

            set
            {
                endMin = value;
            }
        }

        public int LecturerID
        {
            get
            {
                return lecturerID;
            }

            set
            {
                lecturerID = value;
            }
        }

        public string RoomName
        {
            get
            {
                return roomName;
            }

            set
            {
                roomName = value;
            }
        }

        public int RoomSize
        {
            get
            {
                return roomSize;
            }

            set
            {
                roomSize = value;
            }
        }

        public string ModuleFullName
        {
            get
            {
                return moduleFullName;
            }

            set
            {
                moduleFullName = value;
            }
        }

        public string ModuleShortName
        {
            get
            {
                return moduleShortName;
            }

            set
            {
                moduleShortName = value;
            }
        }

        public int Day
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
            }
        }

        public string SessinonProperty
        {
            get
            {
                return sessinonProperty;
            }

            set
            {
                sessinonProperty = value;
            }
        }
    }
}
