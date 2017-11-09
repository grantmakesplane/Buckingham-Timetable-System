using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    class Term
    {
        private int spring;
        private int summer;
        private int autumn;
        private int winter;

        public Term()
        {
            Spring = 0;
            Summer = 0;
            Autumn = 0;
            Winter = 0;
        }

        public int Spring
        {
            get
            {
                return spring;
            }

            set
            {
                spring = value;
            }
        }

        public int Summer
        {
            get
            {
                return summer;
            }

            set
            {
                summer = value;
            }
        }

        public int Autumn
        {
            get
            {
                return autumn;
            }

            set
            {
                autumn = value;
            }
        }

        public int Winter
        {
            get
            {
                return winter;
            }

            set
            {
                winter = value;
            }
        }

        
    }
}
