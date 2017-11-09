using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    class TimeCellDay
    {
        private TimeCellHours[] day = new TimeCellHours[5];

        public TimeCellDay()
        {
            for (int i = 0; i < 5; i++)
            {
                //Day1[i] = ;
            }
        }



        internal TimeCellHours[] Day1
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

        //private List<TimeCellHours> monday;
        //private List<TimeCellHours> tuesday;
        //private List<TimeCellHours> wednesday;
        //private List<TimeCellHours> thursday;
        //private List<TimeCellHours> friday;

        //internal List<TimeCellHours> Monday
        //{
        //    get
        //    {
        //        return monday;
        //    }

        //    set
        //    {
        //        monday = value;
        //    }
        //}

        //internal List<TimeCellHours> Tuesday
        //{
        //    get
        //    {
        //        return tuesday;
        //    }

        //    set
        //    {
        //        tuesday = value;
        //    }
        //}

        //internal List<TimeCellHours> Wednesday
        //{
        //    get
        //    {
        //        return wednesday;
        //    }

        //    set
        //    {
        //        wednesday = value;
        //    }
        //}

        //internal List<TimeCellHours> Thursday
        //{
        //    get
        //    {
        //        return thursday;
        //    }

        //    set
        //    {
        //        thursday = value;
        //    }
        //}

        //internal List<TimeCellHours> Friday
        //{
        //    get
        //    {
        //        return friday;
        //    }

        //    set
        //    {
        //        friday = value;
        //    }
        //}
    }
}
