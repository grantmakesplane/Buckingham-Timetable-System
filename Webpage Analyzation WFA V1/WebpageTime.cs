using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    class WebpageTime
    {
        private int day;
        private int hour;
        private int leftPX;
        private int topPX;
        private int widthPX;
        private int heightPX;

        public int Hour
        {
            get
            {
                return hour;
            }

            set
            {
                hour = value;
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

        public int HeightPX
        {
            get
            {
                return heightPX;
            }

            set
            {
                heightPX = value;
            }
        }
    }
}
