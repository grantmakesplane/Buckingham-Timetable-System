using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    class SessionProperty
    {
        string moduleFullName;
        int practical;
        int tutorial;
        int workshop;

        public string ModuleFullName
        {
            get
            {
                return moduleFullName;
            }

            set
            {
                moduleFullName = value;
            }
        }

        public int Practical
        {
            get
            {
                return practical;
            }

            set
            {
                practical = value;
            }
        }

        public int Tutorial
        {
            get
            {
                return tutorial;
            }

            set
            {
                tutorial = value;
            }
        }

        public int Workshop
        {
            get
            {
                return workshop;
            }

            set
            {
                workshop = value;
            }
        }
    }
}
