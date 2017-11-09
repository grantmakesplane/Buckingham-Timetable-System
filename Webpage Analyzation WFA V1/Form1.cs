using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Webpage_Analyzation_WFA_V1
{
    //public class globalVariable
    //{
    //    SerializeObjects newSerializeObjects = new SerializeObjects();


    //}



    public partial class webpageAnalyzation : Form
    {

        //SerializeObjects newSerializeObjects = new SerializeObjects();

        public webpageAnalyzation()
        {


            //SavingList newSavingList = new SavingList();
            InitializeComponent();
            this.CenterToScreen();
            string url = System.IO.File.ReadAllText("C:/Users/GaoZh/Desktop/individual project/timetable system/webpage analyzation/Computing UG4.html");
            WebpageAnalyzation web = new WebpageAnalyzation();

            //HtmlAgilityPack.HtmlDocument doc = web.DepartmentNodeCollection(url);

            //web.timePX(doc);
            //web.Subject(doc);
            //web.CountSubjectInEachDay(doc);
            //web.CompeletTT(doc);

            //web.print();

            //MondayNine.Text = web.TimetableContainer[0].SubjectFullName;

            //button1_Click.Click = button1_Click + 1;
            // public static object SerializeObjects newSerializeObjects = new SerializeObjects();


        }

        private void MondayNine_Click(object sender, EventArgs e)
        {
            //InitializeComponent();
            //string url = System.IO.File.ReadAllText("C:/Users/GaoZh/Desktop/individual project/timetable system/webpage analyzation/Computing UG4.html");
            //WebpageAnalyzation web = new WebpageAnalyzation();

            //HtmlAgilityPack.HtmlDocument doc = web.DepartmentNodeCollection(url);

            //web.timePX(doc);
            //web.Subject(doc);
            //web.CountSubjectInEachDay(doc);
            //web.CompeletTT(doc);
            //web.print();

            //MondayNine.Text = web.TimetableContainer[0].SubjectFullName ;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Webpage_Analyzation_WFA_V1.AddSubjects().Show();
            //new Webpage_Analyzation_WFA_V1.AddStaffForm().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}

