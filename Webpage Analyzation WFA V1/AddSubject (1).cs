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
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void TimetbleSystem_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows[0].HeaderCell.Value = "Moday";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Label labtest = new Label();
            labtest.Location = new Point(0, 0);
            labtest.Text = "test";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonGrant_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Button buttonGrant = new Button();
            buttonGrant.Text = "hdfoadhfoda";

            tableLayoutPanel1.Controls.Add(buttonGrant, 1, 2);
            tableLayoutPanel1.SetRowSpan(buttonGrant, 2);

            listBox1.Items.Add("11111");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button buttonGrant = new Button();

            switch (listBox1.SelectedIndex) {
            case 0:
                    
                    buttonGrant.Text = "11111";

                    tableLayoutPanel1.Controls.Add(buttonGrant, 1, 2);
                    
                    tableLayoutPanel1.SetRowSpan(buttonGrant, 2);
                    break;
            case 1:
                    
                    buttonGrant.Text = "22222";
                    tableLayoutPanel1.Controls.Remove(buttonGrant);
                    tableLayoutPanel1.Controls.Add(buttonGrant, 1, 2);
                    
                    tableLayoutPanel1.SetRowSpan(buttonGrant, 2);
                    break;
                case 3:

                    buttonGrant.Text = "333333";

                    tableLayoutPanel1.Controls.Add(buttonGrant, 1, 2);
                    tableLayoutPanel1.SetRowSpan(buttonGrant, 2);
                    break;

            }
        }
    }
}
