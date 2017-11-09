using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    public class TimetableCells
    {
        private bool hasSubject;
        private int lecturerPosition;
        private int termTTListPosition;

        public TimetableCells()
        {
            HasSubject = false;
            LecturerPosition = -1;
            TermTTListPosition = -1;
        }

        public bool HasSubject
        {
            get
            {
                return hasSubject;
            }

            set
            {
                hasSubject = value;
            }
        }

        public int LecturerPosition
        {
            get
            {
                return lecturerPosition;
            }

            set
            {
                lecturerPosition = value;
            }
        }

        public int TermTTListPosition
        {
            get
            {
                return termTTListPosition;
            }

            set
            {
                termTTListPosition = value;
            }
        }

        //private int[,] intCells = new int[5,9]; // the first for days, the second for hours
        //private int TTTPosition;

        //public TimetableCells()
        //{
        //    for (int days = 0; days < 5; days++)
        //    {
        //        for (int hours = 0; hours < 9; hours++)
        //        {
        //            IntCells[days, hours] = -1;
        //        }
        //    }

        //    TTTPosition1 = 0;
        //}

        //public int[,] IntCells
        //{
        //    get
        //    {
        //        return intCells;
        //    }

        //    set
        //    {
        //        intCells = value;
        //    }
        //}

        //public int TTTPosition1
        //{
        //    get
        //    {
        //        return TTTPosition;
        //    }

        //    set
        //    {
        //        TTTPosition = value;
        //    }
        //}
    }
}
