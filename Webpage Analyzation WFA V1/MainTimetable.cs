using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    public class MainTimeTable
    {
        List<TimeCellDay> cell;

        internal List<TimeCellDay> Cell
        {
            get
            {
                return cell;
            }

            set
            {
                cell = value;
            }
        }
    }
}
