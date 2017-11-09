using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    class WebpageTimeTable : WebpageSubject
    {
        private int day;
        private int startHour;
        private int startMin;
        private int endHour;
        private int endMin;
        private int lecturerID;

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
    }
}
