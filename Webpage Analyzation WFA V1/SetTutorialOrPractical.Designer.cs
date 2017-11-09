namespace Webpage_Analyzation_WFA_V1
{
    partial class SetTutorialOrPractical
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTTListview = new System.Windows.Forms.ListView();
            this.ModuleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.details_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.finish_button = new System.Windows.Forms.Button();
            this.ModuleNameGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartHourGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndHourGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGridView = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.details_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTTListview
            // 
            this.mainTTListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ModuleName});
            this.mainTTListview.Location = new System.Drawing.Point(12, 23);
            this.mainTTListview.Name = "mainTTListview";
            this.mainTTListview.Size = new System.Drawing.Size(219, 329);
            this.mainTTListview.TabIndex = 0;
            this.mainTTListview.UseCompatibleStateImageBehavior = false;
            this.mainTTListview.View = System.Windows.Forms.View.Details;
            this.mainTTListview.ItemActivate += new System.EventHandler(this.mainTTListview_ItemActivate);
            // 
            // ModuleName
            // 
            this.ModuleName.Text = "Module Name";
            this.ModuleName.Width = 202;
            // 
            // details_dataGridView1
            // 
            this.details_dataGridView1.AllowUserToAddRows = false;
            this.details_dataGridView1.AllowUserToDeleteRows = false;
            this.details_dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.details_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.details_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModuleNameGridView,
            this.roomGridView,
            this.StartHourGridView,
            this.EndHourGridView,
            this.StatusGridView});
            this.details_dataGridView1.Location = new System.Drawing.Point(251, 23);
            this.details_dataGridView1.Name = "details_dataGridView1";
            this.details_dataGridView1.RowTemplate.Height = 23;
            this.details_dataGridView1.Size = new System.Drawing.Size(516, 329);
            this.details_dataGridView1.TabIndex = 1;
            this.details_dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.details_dataGridView1_CellEndEdit);
            // 
            // finish_button
            // 
            this.finish_button.Location = new System.Drawing.Point(692, 377);
            this.finish_button.Name = "finish_button";
            this.finish_button.Size = new System.Drawing.Size(75, 23);
            this.finish_button.TabIndex = 2;
            this.finish_button.Text = "Finish";
            this.finish_button.UseVisualStyleBackColor = true;
            this.finish_button.Click += new System.EventHandler(this.finish_button_Click);
            // 
            // ModuleNameGridView
            // 
            this.ModuleNameGridView.HeaderText = "Short Name";
            this.ModuleNameGridView.Name = "ModuleNameGridView";
            // 
            // roomGridView
            // 
            this.roomGridView.HeaderText = "Room";
            this.roomGridView.Name = "roomGridView";
            // 
            // StartHourGridView
            // 
            this.StartHourGridView.HeaderText = "Start";
            this.StartHourGridView.Name = "StartHourGridView";
            this.StartHourGridView.Width = 80;
            // 
            // EndHourGridView
            // 
            this.EndHourGridView.HeaderText = "End";
            this.EndHourGridView.Name = "EndHourGridView";
            this.EndHourGridView.Width = 80;
            // 
            // StatusGridView
            // 
            this.StatusGridView.HeaderText = "Property";
            this.StatusGridView.Items.AddRange(new object[] {
            "Lecture",
            "Practical",
            "Tutorial",
            "Workshop"});
            this.StatusGridView.Name = "StatusGridView";
            // 
            // SetTutorialOrPractical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 421);
            this.Controls.Add(this.finish_button);
            this.Controls.Add(this.details_dataGridView1);
            this.Controls.Add(this.mainTTListview);
            this.MaximizeBox = false;
            this.Name = "SetTutorialOrPractical";
            this.Text = "SetTutorialOrPractical";
            ((System.ComponentModel.ISupportInitialize)(this.details_dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView mainTTListview;
        private System.Windows.Forms.ColumnHeader ModuleName;
        private System.Windows.Forms.DataGridView details_dataGridView1;
        private System.Windows.Forms.Button finish_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleNameGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartHourGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndHourGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn StatusGridView;
    }
}