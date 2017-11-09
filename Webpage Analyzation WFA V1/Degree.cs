using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    class Degree
    {
        private int undergraduate;
        private int postgraduate;

        public Degree()
        {
            Undergraduate = 0;
            Postgraduate = 0;
        }

        public int Undergraduate
        {
            get
            {
                return undergraduate;
            }

            set
            {
                undergraduate = value;
            }
        }

        public int Postgraduate
        {
            get
            {
                return postgraduate;
            }

            set
            {
                postgraduate = value;
            }
        }

        
    }
}
