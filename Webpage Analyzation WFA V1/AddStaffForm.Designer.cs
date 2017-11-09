namespace Webpage_Analyzation_WFA_V1
{
    partial class AddStaffForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.addStaffDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.LecturerRadioButton = new System.Windows.Forms.RadioButton();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.majorComboBox = new System.Windows.Forms.ComboBox();
            this.majorLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.autumnRadioButton = new System.Windows.Forms.RadioButton();
            this.summerRadioButton = new System.Windows.Forms.RadioButton();
            this.springRadioButton = new System.Windows.Forms.RadioButton();
            this.winterRadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.gradeGroupBox = new System.Windows.Forms.GroupBox();
            this.year_4_RadioButton = new System.Windows.Forms.RadioButton();
            this.year_3_RadioButton = new System.Windows.Forms.RadioButton();
            this.year_2_RadioButton = new System.Windows.Forms.RadioButton();
            this.year_1_RadioButton = new System.Windows.Forms.RadioButton();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.degreeGroupBox = new System.Windows.Forms.GroupBox();
            this.postgraduateButton = new System.Windows.Forms.RadioButton();
            this.undergraduateRadioButton = new System.Windows.Forms.RadioButton();
            this.degreeLabel = new System.Windows.Forms.Label();
            this.AddStaffFormAddButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.departmentComboBox2 = new System.Windows.Forms.ComboBox();
            this.departmentComboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.addStaffDetailsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.studentDetailsGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gradeGroupBox.SuspendLayout();
            this.degreeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.addStaffDetailsGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(701, 430);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // addStaffDetailsGroupBox
            // 
            this.addStaffDetailsGroupBox.Controls.Add(this.LecturerRadioButton);
            this.addStaffDetailsGroupBox.Controls.Add(this.studentRadioButton);
            this.addStaffDetailsGroupBox.Location = new System.Drawing.Point(12, 30);
            this.addStaffDetailsGroupBox.Name = "addStaffDetailsGroupBox";
            this.addStaffDetailsGroupBox.Size = new System.Drawing.Size(112, 89);
            this.addStaffDetailsGroupBox.TabIndex = 0;
            this.addStaffDetailsGroupBox.TabStop = false;
            this.addStaffDetailsGroupBox.Text = "Staff";
            // 
            // LecturerRadioButton
            // 
            this.LecturerRadioButton.AutoSize = true;
            this.LecturerRadioButton.Location = new System.Drawing.Point(6, 53);
            this.LecturerRadioButton.Name = "LecturerRadioButton";
            this.LecturerRadioButton.Size = new System.Drawing.Size(71, 16);
            this.LecturerRadioButton.TabIndex = 1;
            this.LecturerRadioButton.Text = "Lecturer";
            this.LecturerRadioButton.UseVisualStyleBackColor = true;
            this.LecturerRadioButton.CheckedChanged += new System.EventHandler(this.LecturerRadioButton_CheckedChanged);
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Checked = true;
            this.studentRadioButton.Location = new System.Drawing.Point(6, 22);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(65, 16);
            this.studentRadioButton.TabIndex = 0;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            this.studentRadioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.studentRadioButton_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentDetailsGroupBox);
            this.groupBox1.Controls.Add(this.AddStaffFormAddButton);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(this.middleNameTextBox);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.departmentComboBox2);
            this.groupBox1.Controls.Add(this.departmentComboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 374);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // studentDetailsGroupBox
            // 
            this.studentDetailsGroupBox.Controls.Add(this.majorComboBox);
            this.studentDetailsGroupBox.Controls.Add(this.majorLabel);
            this.studentDetailsGroupBox.Controls.Add(this.groupBox2);
            this.studentDetailsGroupBox.Controls.Add(this.label6);
            this.studentDetailsGroupBox.Controls.Add(this.gradeGroupBox);
            this.studentDetailsGroupBox.Controls.Add(this.gradeLabel);
            this.studentDetailsGroupBox.Controls.Add(this.degreeGroupBox);
            this.studentDetailsGroupBox.Controls.Add(this.degreeLabel);
            this.studentDetailsGroupBox.Location = new System.Drawing.Point(24, 178);
            this.studentDetailsGroupBox.Name = "studentDetailsGroupBox";
            this.studentDetailsGroupBox.Size = new System.Drawing.Size(316, 190);
            this.studentDetailsGroupBox.TabIndex = 12;
            this.studentDetailsGroupBox.TabStop = false;
            // 
            // majorComboBox
            // 
            this.majorComboBox.FormattingEnabled = true;
            this.majorComboBox.Items.AddRange(new object[] {
            "Pure Computing"});
            this.majorComboBox.Location = new System.Drawing.Point(76, 139);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(150, 20);
            this.majorComboBox.TabIndex = 8;
            this.majorComboBox.Text = "None";
            this.majorComboBox.SelectedIndexChanged += new System.EventHandler(this.majorComboBox_SelectedIndexChanged);
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(22, 142);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(41, 12);
            this.majorLabel.TabIndex = 7;
            this.majorLabel.Text = "Major:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.autumnRadioButton);
            this.groupBox2.Controls.Add(this.summerRadioButton);
            this.groupBox2.Controls.Add(this.springRadioButton);
            this.groupBox2.Controls.Add(this.winterRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(76, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 32);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // autumnRadioButton
            // 
            this.autumnRadioButton.AutoSize = true;
            this.autumnRadioButton.Location = new System.Drawing.Point(114, 10);
            this.autumnRadioButton.Name = "autumnRadioButton";
            this.autumnRadioButton.Size = new System.Drawing.Size(29, 16);
            this.autumnRadioButton.TabIndex = 7;
            this.autumnRadioButton.Text = "4";
            this.autumnRadioButton.UseVisualStyleBackColor = true;
            this.autumnRadioButton.CheckedChanged += new System.EventHandler(this.autumnRadioButton_CheckedChanged);
            // 
            // summerRadioButton
            // 
            this.summerRadioButton.AutoSize = true;
            this.summerRadioButton.Location = new System.Drawing.Point(79, 11);
            this.summerRadioButton.Name = "summerRadioButton";
            this.summerRadioButton.Size = new System.Drawing.Size(29, 16);
            this.summerRadioButton.TabIndex = 6;
            this.summerRadioButton.Text = "3";
            this.summerRadioButton.UseVisualStyleBackColor = true;
            this.summerRadioButton.CheckedChanged += new System.EventHandler(this.summerRadioButton_CheckedChanged);
            // 
            // springRadioButton
            // 
            this.springRadioButton.AutoSize = true;
            this.springRadioButton.Location = new System.Drawing.Point(39, 11);
            this.springRadioButton.Name = "springRadioButton";
            this.springRadioButton.Size = new System.Drawing.Size(29, 16);
            this.springRadioButton.TabIndex = 5;
            this.springRadioButton.Text = "2";
            this.springRadioButton.UseVisualStyleBackColor = true;
            this.springRadioButton.CheckedChanged += new System.EventHandler(this.springRadioButton_CheckedChanged);
            // 
            // winterRadioButton
            // 
            this.winterRadioButton.AutoSize = true;
            this.winterRadioButton.Checked = true;
            this.winterRadioButton.Location = new System.Drawing.Point(6, 11);
            this.winterRadioButton.Name = "winterRadioButton";
            this.winterRadioButton.Size = new System.Drawing.Size(29, 16);
            this.winterRadioButton.TabIndex = 1;
            this.winterRadioButton.TabStop = true;
            this.winterRadioButton.Text = "1";
            this.winterRadioButton.UseVisualStyleBackColor = true;
            this.winterRadioButton.CheckedChanged += new System.EventHandler(this.winterRadioButton_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Term:";
            // 
            // gradeGroupBox
            // 
            this.gradeGroupBox.Controls.Add(this.year_4_RadioButton);
            this.gradeGroupBox.Controls.Add(this.year_3_RadioButton);
            this.gradeGroupBox.Controls.Add(this.year_2_RadioButton);
            this.gradeGroupBox.Controls.Add(this.year_1_RadioButton);
            this.gradeGroupBox.Location = new System.Drawing.Point(76, 55);
            this.gradeGroupBox.Name = "gradeGroupBox";
            this.gradeGroupBox.Size = new System.Drawing.Size(150, 32);
            this.gradeGroupBox.TabIndex = 4;
            this.gradeGroupBox.TabStop = false;
            // 
            // year_4_RadioButton
            // 
            this.year_4_RadioButton.AutoSize = true;
            this.year_4_RadioButton.Location = new System.Drawing.Point(115, 10);
            this.year_4_RadioButton.Name = "year_4_RadioButton";
            this.year_4_RadioButton.Size = new System.Drawing.Size(29, 16);
            this.year_4_RadioButton.TabIndex = 4;
            this.year_4_RadioButton.Text = "4";
            this.year_4_RadioButton.UseVisualStyleBackColor = true;
            this.year_4_RadioButton.CheckedChanged += new System.EventHandler(this.year_4_RadioButton_CheckedChanged);
            // 
            // year_3_RadioButton
            // 
            this.year_3_RadioButton.AutoSize = true;
            this.year_3_RadioButton.Location = new System.Drawing.Point(79, 10);
            this.year_3_RadioButton.Name = "year_3_RadioButton";
            this.year_3_RadioButton.Size = new System.Drawing.Size(29, 16);
            this.year_3_RadioButton.TabIndex = 3;
            this.year_3_RadioButton.Text = "3";
            this.year_3_RadioButton.UseVisualStyleBackColor = true;
            this.year_3_RadioButton.CheckedChanged += new System.EventHandler(this.year_3_RadioButton_CheckedChanged);
            // 
            // year_2_RadioButton
            // 
            this.year_2_RadioButton.AutoSize = true;
            this.year_2_RadioButton.Location = new System.Drawing.Point(40, 10);
            this.year_2_RadioButton.Name = "year_2_RadioButton";
            this.year_2_RadioButton.Size = new System.Drawing.Size(29, 16);
            this.year_2_RadioButton.TabIndex = 2;
            this.year_2_RadioButton.Text = "2";
            this.year_2_RadioButton.UseVisualStyleBackColor = true;
            this.year_2_RadioButton.CheckedChanged += new System.EventHandler(this.year_2_RadioButton_CheckedChanged);
            // 
            // year_1_RadioButton
            // 
            this.year_1_RadioButton.AutoSize = true;
            this.year_1_RadioButton.Checked = true;
            this.year_1_RadioButton.Location = new System.Drawing.Point(6, 10);
            this.year_1_RadioButton.Name = "year_1_RadioButton";
            this.year_1_RadioButton.Size = new System.Drawing.Size(29, 16);
            this.year_1_RadioButton.TabIndex = 1;
            this.year_1_RadioButton.TabStop = true;
            this.year_1_RadioButton.Text = "1";
            this.year_1_RadioButton.UseVisualStyleBackColor = true;
            this.year_1_RadioButton.CheckedChanged += new System.EventHandler(this.year_1_RadioButton_CheckedChanged);
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(22, 67);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(41, 12);
            this.gradeLabel.TabIndex = 3;
            this.gradeLabel.Text = "Grade:";
            // 
            // degreeGroupBox
            // 
            this.degreeGroupBox.Controls.Add(this.postgraduateButton);
            this.degreeGroupBox.Controls.Add(this.undergraduateRadioButton);
            this.degreeGroupBox.Location = new System.Drawing.Point(76, 17);
            this.degreeGroupBox.Name = "degreeGroupBox";
            this.degreeGroupBox.Size = new System.Drawing.Size(150, 32);
            this.degreeGroupBox.TabIndex = 2;
            this.degreeGroupBox.TabStop = false;
            // 
            // postgraduateButton
            // 
            this.postgraduateButton.AutoSize = true;
            this.postgraduateButton.Location = new System.Drawing.Point(78, 10);
            this.postgraduateButton.Name = "postgraduateButton";
            this.postgraduateButton.Size = new System.Drawing.Size(35, 16);
            this.postgraduateButton.TabIndex = 2;
            this.postgraduateButton.Text = "PG";
            this.postgraduateButton.UseVisualStyleBackColor = true;
            this.postgraduateButton.CheckedChanged += new System.EventHandler(this.postgraduateButton_CheckedChanged);
            // 
            // undergraduateRadioButton
            // 
            this.undergraduateRadioButton.AutoSize = true;
            this.undergraduateRadioButton.Checked = true;
            this.undergraduateRadioButton.Location = new System.Drawing.Point(6, 10);
            this.undergraduateRadioButton.Name = "undergraduateRadioButton";
            this.undergraduateRadioButton.Size = new System.Drawing.Size(35, 16);
            this.undergraduateRadioButton.TabIndex = 1;
            this.undergraduateRadioButton.TabStop = true;
            this.undergraduateRadioButton.Text = "UG";
            this.undergraduateRadioButton.UseVisualStyleBackColor = true;
            this.undergraduateRadioButton.CheckedChanged += new System.EventHandler(this.undergraduateRadioButton_CheckedChanged);
            // 
            // degreeLabel
            // 
            this.degreeLabel.AutoSize = true;
            this.degreeLabel.Location = new System.Drawing.Point(22, 29);
            this.degreeLabel.Name = "degreeLabel";
            this.degreeLabel.Size = new System.Drawing.Size(47, 12);
            this.degreeLabel.TabIndex = 0;
            this.degreeLabel.Text = "Degree:";
            // 
            // AddStaffFormAddButton
            // 
            this.AddStaffFormAddButton.Location = new System.Drawing.Point(355, 345);
            this.AddStaffFormAddButton.Name = "AddStaffFormAddButton";
            this.AddStaffFormAddButton.Size = new System.Drawing.Size(75, 23);
            this.AddStaffFormAddButton.TabIndex = 6;
            this.AddStaffFormAddButton.Text = "Add";
            this.AddStaffFormAddButton.UseVisualStyleBackColor = true;
            this.AddStaffFormAddButton.Click += new System.EventHandler(this.AddStaffFormAddButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(100, 100);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(150, 21);
            this.lastNameTextBox.TabIndex = 11;
            this.lastNameTextBox.Text = "Last Name";
            this.lastNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lastNameTextBox_MouseClick);
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(100, 74);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(150, 21);
            this.middleNameTextBox.TabIndex = 10;
            this.middleNameTextBox.Text = "Middle Name";
            this.middleNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.middleNameTextBox_MouseClick);
            this.middleNameTextBox.TextChanged += new System.EventHandler(this.middleNameTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(100, 48);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(150, 21);
            this.firstNameTextBox.TabIndex = 9;
            this.firstNameTextBox.Tag = "";
            this.firstNameTextBox.Text = "First Name";
            this.firstNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.firstNameTextBox_MouseClick);
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(100, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(150, 21);
            this.idTextBox.TabIndex = 8;
            this.idTextBox.Text = "ID";
            this.idTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.idTextBox_MouseClick);
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // departmentComboBox2
            // 
            this.departmentComboBox2.FormattingEnabled = true;
            this.departmentComboBox2.Items.AddRange(new object[] {
            "None",
            "Applied Computing",
            "Psychology",
            "Business",
            "Medical",
            "Law"});
            this.departmentComboBox2.Location = new System.Drawing.Point(100, 152);
            this.departmentComboBox2.Name = "departmentComboBox2";
            this.departmentComboBox2.Size = new System.Drawing.Size(150, 20);
            this.departmentComboBox2.TabIndex = 7;
            this.departmentComboBox2.Text = "None";
            this.departmentComboBox2.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox2_SelectedIndexChanged);
            // 
            // departmentComboBox1
            // 
            this.departmentComboBox1.FormattingEnabled = true;
            this.departmentComboBox1.Items.AddRange(new object[] {
            "None",
            "Applied Computing",
            "Psychology",
            "Business",
            "Medical",
            "Law"});
            this.departmentComboBox1.Location = new System.Drawing.Point(100, 127);
            this.departmentComboBox1.Name = "departmentComboBox1";
            this.departmentComboBox1.Size = new System.Drawing.Size(150, 20);
            this.departmentComboBox1.TabIndex = 6;
            this.departmentComboBox1.Text = "None";
            this.departmentComboBox1.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Middle Name:";
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 430);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AddStaffForm";
            this.Text = "AddStaffForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.addStaffDetailsGroupBox.ResumeLayout(false);
            this.addStaffDetailsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.studentDetailsGroupBox.ResumeLayout(false);
            this.studentDetailsGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gradeGroupBox.ResumeLayout(false);
            this.gradeGroupBox.PerformLayout();
            this.degreeGroupBox.ResumeLayout(false);
            this.degreeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox addStaffDetailsGroupBox;
        private System.Windows.Forms.RadioButton LecturerRadioButton;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox departmentComboBox2;
        private System.Windows.Forms.ComboBox departmentComboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button AddStaffFormAddButton;
        private System.Windows.Forms.GroupBox studentDetailsGroupBox;
        private System.Windows.Forms.Label degreeLabel;
        private System.Windows.Forms.GroupBox degreeGroupBox;
        private System.Windows.Forms.RadioButton postgraduateButton;
        private System.Windows.Forms.RadioButton undergraduateRadioButton;
        private System.Windows.Forms.GroupBox gradeGroupBox;
        private System.Windows.Forms.RadioButton year_2_RadioButton;
        private System.Windows.Forms.RadioButton year_1_RadioButton;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.RadioButton year_3_RadioButton;
        private System.Windows.Forms.RadioButton year_4_RadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton winterRadioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton autumnRadioButton;
        private System.Windows.Forms.RadioButton summerRadioButton;
        private System.Windows.Forms.RadioButton springRadioButton;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.ComboBox majorComboBox;
    }
}