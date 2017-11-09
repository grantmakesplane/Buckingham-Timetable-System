using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    class WebpageSubject
    {
        private int day;
        private string subjectFullName;
        private string subjectShortName;
        private string roomName;
        private int roomSize;
        private int roomSizeTaken;
        private int leftPX;
        private int topPX;
        private int widthPX;


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

        public int RoomSizeTaken
        {
            get
            {
                return roomSizeTaken;
            }

            set
            {
                roomSizeTaken = value;
            }
        }

        public int LeftPX
        {
            get
            {
                return leftPX;
            }

            set
            {
                leftPX = value;
            }
        }

        public int TopPX
        {
            get
            {
                return topPX;
            }

            set
            {
                topPX = value;
            }
        }

        public int WidthPX
        {
            get
            {
                return widthPX;
            }

            set
            {
                widthPX = value;
            }
        }

        public string SubjectFullName
        {
            get
            {
                return subjectFullName;
            }

            set
            {
                subjectFullName = value;
            }
        }

        public string SubjectShortName
        {
            get
            {
                return subjectShortName;
            }

            set
            {
                subjectShortName = value;
            }
        }
    }
}
