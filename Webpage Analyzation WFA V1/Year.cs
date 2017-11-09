using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    class Year
    {
        private int year_x;
        private int year_y;

        public Year()
        {
            Year_x = 1;
            Year_y = 7;
        }

        public int Year_x
        {
            get
            {
                return year_x;
            }

            set
            {
                year_x = value;
            }
        }

        public int Year_y
        {
            get
            {
                return year_y;
            }

            set
            {
                year_y = value;
            }
        }
    }
}
