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
    public partial class SetTutorialOrPractical : Form
    {
        public SetTutorialOrPractical()
        {
            InitializeComponent();
            displayModuleName();
        }

        private void mainTTListview_ItemActivate(object sender, EventArgs e)
        {
            var moduleFullName = mainTTListview.SelectedItems[0].SubItems[0].Text;


            SavingAndReading data = new SavingAndReading();
            data.ReadTermTimetableFile();

            details_dataGridView1.Rows.Clear();

            foreach(WebpageTermTimetable e1 in SystemList.TermTimetableList)
            {
                if(e1.ModuleFullName == moduleFullName && e1.ModuleShortName.Last() != '1')
                {
                    ListViewItem item = new ListViewItem();

                    var shortName = e1.ModuleShortName;
                    var roomName = e1.RoomName;
                    var startHour = e1.StartHour;
                    var endHour = e1.EndHour;
                    var sessionProperty = e1.SessinonProperty;
                    
                    details_dataGridView1.Rows.Add(shortName, roomName, startHour, endHour, sessionProperty);
                }
            }
        }

        private void displayModuleName()
        {
            SavingAndReading data = new SavingAndReading();
            data.ReadTermTimetableFile();

            foreach(WebpageTermTimetable e1 in SystemList.TermTimetableList)
            {
                if(e1.ModuleShortName.Last() == '1')
                {
                    ListViewItem item = new ListViewItem();

                    //var moduleFullName = e1.ModuleFullName;
                    item.Text = e1.ModuleFullName;

                    mainTTListview.Items.Add(item);
                }
            }
        }


        private void details_dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var firstColumnValue = details_dataGridView1[0, e.RowIndex].Value.ToString();
            var property = details_dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();

            changeSessionProperty(firstColumnValue, property);
            //MessageBox.Show(details_dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        private void changeSessionProperty(string ModuleShortName, string sessionProperty)
        {
            SavingAndReading data = new SavingAndReading();
            data.ReadTermTimetableFile();

            foreach(WebpageTermTimetable e1 in SystemList.TermTimetableList)
            {
                if(e1.ModuleShortName == ModuleShortName)
                {
                    e1.SessinonProperty = sessionProperty;
                }
            }

            data.WriteTermTimetable();
        }

        private void finish_button_Click(object sender, EventArgs e)
        {
            
            AddSubjects newAdd = new AddSubjects();
            newAdd.createTemplate();
            this.Close();
        }



        //private void details_dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show(e.ToString());
        //}

        //private void details_dataGridView1_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        //{
        //    System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
        //    messageBoxCS.AppendFormat("{0} = {1}", "Column", e.Column);
        //    messageBoxCS.AppendLine();
        //    MessageBox.Show(messageBoxCS.ToString(), "ColumnDisplayIndexChanged Event");
        //}

        //private void detailsListview_ItemActivate(object sender, EventArgs e)
        //{
        //    SavingAndReading data = new SavingAndReading();
        //    data.ReadTermTimetableFile();

        //    //MessageBox.Show
        //}
    }
}
