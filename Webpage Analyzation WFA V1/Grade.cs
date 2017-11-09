using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    class Grade
    {
        private int year_1;
        private int year_2;
        private int year_3;
        private int year_4;

        public Grade()
        {
            Year_1 = 0;
            Year_2 = 0;
            Year_3 = 0;
            Year_4 = 0;
        }

        public int Year_1
        {
            get
            {
                return year_1;
            }

            set
            {
                year_1 = value;
            }
        }

        public int Year_2
        {
            get
            {
                return year_2;
            }

            set
            {
                year_2 = value;
            }
        }

        public int Year_3
        {
            get
            {
                return year_3;
            }

            set
            {
                year_3 = value;
            }
        }

        public int Year_4
        {
            get
            {
                return year_4;
            }

            set
            {
                year_4 = value;
            }
        }
    }
}
