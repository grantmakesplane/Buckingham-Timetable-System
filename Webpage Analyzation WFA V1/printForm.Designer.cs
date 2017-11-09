namespace Webpage_Analyzation_WFA_V1
{
    partial class printForm
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
            this.printStudent_button = new System.Windows.Forms.Button();
            this.printLecturer_button = new System.Windows.Forms.Button();
            this.printRoom_button = new System.Windows.Forms.Button();
            this.printMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printStudent_button
            // 
            this.printStudent_button.Location = new System.Drawing.Point(36, 96);
            this.printStudent_button.Name = "printStudent_button";
            this.printStudent_button.Size = new System.Drawing.Size(75, 62);
            this.printStudent_button.TabIndex = 0;
            this.printStudent_button.Text = "Student";
            this.printStudent_button.UseVisualStyleBackColor = true;
            this.printStudent_button.Click += new System.EventHandler(this.printStudent_button_Click);
            // 
            // printLecturer_button
            // 
            this.printLecturer_button.Location = new System.Drawing.Point(171, 96);
            this.printLecturer_button.Name = "printLecturer_button";
            this.printLecturer_button.Size = new System.Drawing.Size(75, 62);
            this.printLecturer_button.TabIndex = 1;
            this.printLecturer_button.Text = "Lecturer";
            this.printLecturer_button.UseVisualStyleBackColor = true;
            this.printLecturer_button.Click += new System.EventHandler(this.printLecturer_button_Click);
            // 
            // printRoom_button
            // 
            this.printRoom_button.Location = new System.Drawing.Point(313, 96);
            this.printRoom_button.Name = "printRoom_button";
            this.printRoom_button.Size = new System.Drawing.Size(75, 62);
            this.printRoom_button.TabIndex = 2;
            this.printRoom_button.Text = "Room";
            this.printRoom_button.UseVisualStyleBackColor = true;
            this.printRoom_button.Click += new System.EventHandler(this.printRoom_button_Click);
            // 
            // printMessage
            // 
            this.printMessage.AutoSize = true;
            this.printMessage.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.printMessage.Location = new System.Drawing.Point(47, 31);
            this.printMessage.Name = "printMessage";
            this.printMessage.Size = new System.Drawing.Size(359, 16);
            this.printMessage.TabIndex = 3;
            this.printMessage.Text = "Select one in below to print timetables";
            // 
            // printForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 261);
            this.Controls.Add(this.printMessage);
            this.Controls.Add(this.printRoom_button);
            this.Controls.Add(this.printLecturer_button);
            this.Controls.Add(this.printStudent_button);
            this.Name = "printForm";
            this.Text = "printForm";
            this.Load += new System.EventHandler(this.printForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printStudent_button;
        private System.Windows.Forms.Button printLecturer_button;
        private System.Windows.Forms.Button printRoom_button;
        private System.Windows.Forms.Label printMessage;
    }
}