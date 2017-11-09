using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webpage_Analyzation_WFA_V1
{
    public partial class printForm : Form
    {
        private string yearXText = "1";
        private string yearYText = "5";
        private int degree = 1;
        private int grade = 1;
        private int term = 1;

        //public printForm()
        //{
        //    YearXText = "1";
        //    YearYText = "5";
        //    Degree = 1;
        //    Grade = 1;
        //    Term = 1;
        //}

        public string YearXText
        {
            get
            {
                return yearXText;
            }

            set
            {
                yearXText = value;
            }
        }

        public string YearYText
        {
            get
            {
                return yearYText;
            }

            set
            {
                yearYText = value;
            }
        }

        public int Degree
        {
            get
            {
                return degree;
            }

            set
            {
                degree = value;
            }
        }

        public int Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }

        public int Term
        {
            get
            {
                return term;
            }

            set
            {
                term = value;
            }
        }

        public printForm()
        {
            InitializeComponent();
        }

        private void printRoom_button_Click(object sender, EventArgs e)
        {
            ProduceTT print = new ProduceTT();
            print.produceRoomTimetable();
        }

        private void printForm_Load(object sender, EventArgs e)
        {

        }

        private void printStudent_button_Click(object sender, EventArgs e)
        {
            ProduceTT newProduce = new ProduceTT();
            newProduce.produceStudentTimetable(this.YearXText, this.YearYText, this.Degree, this.Grade, this.Term);

            MessageBox.Show("Done");
        }

        private void printLecturer_button_Click(object sender, EventArgs e)
        {
            ProduceTT newProduce = new ProduceTT();
            newProduce.prodceLecturer();
            MessageBox.Show("Done");
        }
    }
}
