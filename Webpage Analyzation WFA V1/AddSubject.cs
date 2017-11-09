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
    public partial class AddSubjects : Form
    {
        private string yearXText = "1";
        private string yearYText = "5";
        private int degree = 1;
        private int grade = 1;
        private int term = 1;

        private int tapPage = 1;
       

        public AddSubjects()
        {
            InitializeComponent();
        }

        private void TimetbleSystem_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ////BasicStaffInfo newBasicInfo = new BasicStaffInfo();
            //newBasicInfo.YearX = yearXText;
            //newBasicInfo.YearY = yearYText;
            //newBasicInfo.Degree = degree;
            //newBasicInfo.Grade = grade;
            //newBasicInfo.Term = term;
            //newBasicInfo.storageBasicStaffInfo();
            new AddStaffForm().Show();
            
        }

        private void yearYBox_TextChanged(object sender, EventArgs e)
        {
            //yearYText = int.Parse(yearYBox.Text);
            yearYText = yearYBox.Text;
        }

        private void yearXBox_TextChanged(object sender, EventArgs e)
        {
            //yearXText = int.Parse(yearXBox.Text);
            yearXText = yearXBox.Text;
        }



        private void postgraduateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            degree = 2;
        }

        private void undergraduateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            degree = 1;
        }

        //private void degreeGroupBox_Enter(object sender, EventArgs e)
        //{
        //    if (undergraduateRadioButton.Checked)
        //        degree = 1;
        //    else if (postgraduateRadioButton.Checked)
        //        degree = 2;
        //}

        //private void gradeGroupBox_Enter(object sender, EventArgs e)
        //{
        //    if (year_1_radioButton.Checked)
        //        grade = 1;
        //    else if (year_2_radioButton.Checked)
        //        grade = 2;
        //    else if (year_3_radioButton.Checked)
        //        grade = 3;
        //}

        //private void termGroupBox_Enter(object sender, EventArgs e)
        //{
        //    if (winterRadioButton.Checked)
        //        term = 1;
        //    else if (springRadioButton.Checked)
        //        term = 2;
        //    else if (summerRadioButton.Checked)
        //        term = 3;
        //    else if (autumnRadioButton.Checked)
        //        term = 4;
        //}

        private void read_button_Click(object sender, EventArgs e)
        {
            //displayListView(1);
        }

        private void year_1_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            grade = 1;
        }

        private void year_2_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            grade = 2;
        }

        private void year_3_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            grade = 3;
        }

        private void winterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            term = 1;
        }

        private void springRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            term = 2;
        }

        private void summerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            term = 3;
        }

        private void autumnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            term = 4;
        }

        private void studentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentListView.View = View.Details;
            int totalStudents = SystemList.StudentList.Count();
            int[][] int_row = new int[totalStudents][];
            

            for (int i = 1; i < totalStudents; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = SystemList.StudentList[i].Id.ToString();
                //for (int j = 0; j < totalStudents; j++)
                {

                    item.SubItems.Add(SystemList.StudentList[i].FirstName + SystemList.StudentList[i].LastName);
                }
                
            }

            //foreach(Student e1 in SystemList.StudentList)
            //{
            //    ListViewItem row = new ListViewItem();
            //    row.SubItems.Add()
            //}
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Cursor Files|*.html";
            openFileDialog.Title = "Select a Cursor File";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //this.Cursor = new Cursor(openFileDialog.OpenFile());
                var fileName = openFileDialog.FileName;
                WebpageAnalyzation web = new WebpageAnalyzation();
                web.WebpageAnalyzationMain(fileName);

                //seperate details to rooms
                Room newRoom = new Room();
                newRoom.collectTTTInfo(newRoom);

                
                MessageBox.Show("Finished Analyzation!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                SavingAndReading save = new SavingAndReading();
                save.WriteSystemList();

                this.Close();
            }

            
        }

        //private void read_button_Click(object sender, EventArgs e)
        //{
            
        //}

        private void save_button_Click(object sender, EventArgs e)
        {
            SavingAndReading data = new SavingAndReading();
            data.WriteSystemList();
        }

        private void ListTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tapPage = ListTabControl.SelectedIndex;
            displayListView(tapPage);
        }

        private void ListTabControl_Click(object sender, EventArgs e)
        {

        }

        private void displayListView(int tabPage)
        {
            SavingAndReading data = new SavingAndReading();
            //data.ReadSystemList();
            //displayStudentListView();
            //displayLecturerListView();
            switch (tabPage)
            {
                case 0:
                    data.ReadStudentFile();
                    displayStudentListView();
                    break;
                case 1:
                    data.ReadLecturerFile();
                    displayLecturerListView();
                    break;
                case 2:
                    data.ReadRoomFile(data.RoomFilename);
                    displayRoomListView();
                    break;

            }

        }


        //to display students basic infomation in listTapControl
        private void displayStudentListView()
        {
            
            List<Student> tempStudentList = new List<Student>();

            //foreach (Student e1 in SystemList.StudentList)
            //{
            //    char yearX = e1.Id.ToString()[0];
            //    char yearY = e1.Id.ToString()[1];
            //    string year = string.Format("{0}{1}", yearX, yearY);

            //    if (year == yearXText + yearYText && e1.Degree == degree && e1.Grade == grade && e1.Term == term)
            //    {
            //        tempStudentList.Add(e1);
            //    }
            //}

            tempStudentList = returnStudentList();

            if (tempStudentList != null)
            {
                studentListView.View = View.Details;
                int totalStudents = tempStudentList.Count();


                studentListView.Items.Clear();
                for (int i = 0; i < totalStudents; i++)
                {
                    ListViewItem item = new ListViewItem();
                    Student newStudent = new Student();
                    newStudent = tempStudentList[i];

                    item.Text = newStudent.Id.ToString();
                    var firstName = newStudent.FirstName;
                    var lastName = newStudent.LastName;
                    item.SubItems.Add(firstName + " " + lastName);

                    studentListView.Items.Add(item);
                }


            }
        }

        //to display lecturers basic infomation in listTapControl
        private void displayLecturerListView()
        {
            if (SystemList.LecturerList != null)
            {
                List<Lecturer> tempLecturerList = SystemList.LecturerList;

                lecturerListView.View = View.Details;
                int totalLecturers = tempLecturerList.Count();


                lecturerListView.Items.Clear();
                for (int i = 0; i < totalLecturers; i++)
                {
                    ListViewItem item = new ListViewItem();                   
                    Lecturer newLecturer = new Lecturer();
                    newLecturer = tempLecturerList[i];

                    item.Text = newLecturer.Id.ToString();
                    var firstName = newLecturer.FirstName;
                    var lastName = newLecturer.LastName;
                    item.SubItems.Add(firstName + " " + lastName);

                    lecturerListView.Items.Add(item);
                }
            }
        }

        private void displayRoomListView()
        {

            if (SystemList.RoomsList != null)
            {
                List<Room> tempRoomList = SystemList.RoomsList;

                roomListView.View = View.Details;
                int totalRooms = tempRoomList.Count();


                roomListView.Items.Clear();
                for (int i = 0; i < totalRooms; i++)
                {
                    ListViewItem item = new ListViewItem();
                    Room newRoom = new Room();
                    newRoom = tempRoomList[i];

                    item.Text = newRoom.RoomName;
                    var size = newRoom.RoomSize.ToString();
                    item.SubItems.Add(size);

                    roomListView.Items.Add(item);
                }
            }
        }

        private void roomListView_ItemActivate(object sender, EventArgs e)
        {
            SavingAndReading data = new SavingAndReading();
            data.ReadRoomFile(data.RoomFilename);
            data.ReadTermTimetableFile();
            data.ReadLecturerFile();
            


            Room newRoom = new Room();
            newRoom.RoomName = roomListView.SelectedItems[0].SubItems[0].Text;
            //timetableLayoutPanel.Controls.Clear();
            removeControls();
            //drawingTimetable();
            foreach (Room e1 in SystemList.RoomsList)
            {
                if(e1.RoomName == newRoom.RoomName)
                {
                    for(int i = 0; i < 5; i++)
                    {
                        for(int j = 0; j < 9; j++)
                        {
                            if(e1.TtDimensionArray[i][j].HasSubject == true)
                            {
                                var position = e1.TtDimensionArray[i][j].TermTTListPosition;
                                var ttDetails = SystemList.TermTimetableList[position];

                                var moduleFullName = ttDetails.ModuleFullName;
                                var moduleShortName = ttDetails.ModuleShortName.Substring(3, ttDetails.ModuleShortName.Count() - 3);
                                var roomName = ttDetails.RoomName;
                                var lecturerName = findLecturerName(ttDetails.LecturerID);
                                var row = ttDetails.Day + 1;
                                var column = ttDetails.StartHour - 8;
                                var columnspan = ttDetails.EndHour - ttDetails.StartHour;

                                Label newLabel = new Label();
                                newLabel.Dock = DockStyle.Fill;
                                newLabel.Text = newRoom.RoomName + "\n" + moduleShortName + "\n" + lecturerName;
                                newLabel.TextAlign = ContentAlignment.MiddleCenter;
                                timetableLayoutPanel.Controls.Add(newLabel);
                                timetableLayoutPanel.SetCellPosition(newLabel, new TableLayoutPanelCellPosition(column,row));
                                
                                if(columnspan > 1)
                                timetableLayoutPanel.SetColumnSpan(newLabel, columnspan);
                            }
                        }
                    }
                }
            }

            //Label newLabel = new Label();
            //newLabel.Dock = DockStyle.Fill;
            //newLabel.Text = newRoom.RoomName;
            //timetableLayoutPanel.Controls.Add(newLabel);
            //timetableLayoutPanel.SetCellPosition(newLabel, new TableLayoutPanelCellPosition(1, 1));
            //timetableLayoutPanel.SetColumnSpan(newLabel, 2);

            
            //timetableLayoutPanel.Controls.Add(new Label() {Text = "asdf", Dock = DockStyle.Fill  }, 1,1);
            //timetableLayoutPanel.GetCellPosition;
            //timetableLayoutPanel.GetCellPosition()
        }

        private void removeControls()
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (Control c in timetableLayoutPanel.Controls)
                {
                    var row = timetableLayoutPanel.GetCellPosition(c).Row;
                    var column = timetableLayoutPanel.GetCellPosition(c).Column;

                    if (row >= 1 && column >= 1)
                        timetableLayoutPanel.Controls.Remove(c);
                }
            }
            //timetableLayoutPanel.Controls.Clear();

        }

        //private void drawingTimetable()
        //{
        //    List<string> hourList = new List<string> { "9:00\n-\n9:50", "10:00\n-\n10:50", "11:15\n-\n12:05", "12:15\n-\n13:05", "13:15", "14:15\n-\n15:05", "15:15\n-\n16:05", "16:15\n-\n17:05", "17:15\n-\n18:00" };
        //    List<string> dayList = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        //    timetableLayoutPanel.Controls.Clear();

        //    for (int i = 0; i < hourList.Count(); i++)
        //    {
        //        Label newLabel = new Label();
        //        newLabel.Dock = DockStyle.Fill;
        //        newLabel.Text = hourList[i];
        //        newLabel.TextAlign = ContentAlignment.MiddleCenter;
        //        timetableLayoutPanel.Controls.Add(newLabel);
        //        timetableLayoutPanel.SetCellPosition(newLabel, new TableLayoutPanelCellPosition(i + 1, 0));
        //    }

        //    for (int i = 0; i < dayList.Count(); i++)
        //    {
        //        Label newLabel = new Label();
        //        newLabel.Dock = DockStyle.Fill;
        //        newLabel.Text = dayList[i];
        //        newLabel.TextAlign = ContentAlignment.MiddleCenter;
        //        newLabel.Font = new Font("SimSum", 9, FontStyle.Bold);
        //        timetableLayoutPanel.Controls.Add(newLabel);
        //        timetableLayoutPanel.SetCellPosition(newLabel, new TableLayoutPanelCellPosition(0, i + 1));
        //    }

        //}

        private string findLecturerName(int lecturerID)
        {
            string lecturerName = "";
            SavingAndReading data = new SavingAndReading();
            data.ReadLecturerFile();

            foreach (Lecturer e1 in SystemList.LecturerList)
            {
                if (e1.Id == lecturerID)
                    lecturerName = (e1.FirstName + e1.MiddleName + " " + e1.LastName);
            }

            return lecturerName;
        }

        private string removeSUF(string shortName)
        {
            char[] cropingShortName = new char[shortName.Count()];

            for (int i = 3; i < shortName.Count(); i++)
            {
                cropingShortName[i - 3] = shortName[i];
            }

            
            return cropingShortName.ToString();
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            //new printForm().Show();
            AddSubjects addSubjectsForm = new AddSubjects();
            addSubjectsForm.createTemplate();

            printForm newForm = new printForm();
            newForm.YearXText = yearXText;
            newForm.YearYText = yearYText;
            newForm.Degree = degree;
            newForm.Grade = grade;
            newForm.Term = term;

            newForm.Show();
            


        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            new SetTutorialOrPractical().Show();
        }

        private void lecturerListView_ItemActivate(object sender, EventArgs e)
        {
            SavingAndReading data = new SavingAndReading();
            data.ReadRoomFile(data.RoomFilename);
            data.ReadTermTimetableFile();
            data.ReadLecturerFile();


            removeControls();
            //collect the modules a lecuter is teaching
            var id = lecturerListView.SelectedItems[0].SubItems[0].Text;
            //List<Module> tempModuleList = new List<Module>();

            foreach (WebpageTermTimetable e1 in SystemList.TermTimetableList)
            {
                if (e1.LecturerID.ToString() == id)
                {
                    var moduleShortName = e1.ModuleShortName.Substring(3);
                    var roomName = e1.RoomName;
                    var row = e1.Day + 1;
                    var column = e1.StartHour - 8;
                    var columnspan = e1.EndHour - e1.StartHour;


                    Label newLabel = new Label();
                    newLabel.Dock = DockStyle.Fill;
                    newLabel.Text = roomName + "\n" + moduleShortName + "\n";
                    newLabel.TextAlign = ContentAlignment.MiddleCenter;
                    timetableLayoutPanel.Controls.Add(newLabel);
                    timetableLayoutPanel.SetCellPosition(newLabel, new TableLayoutPanelCellPosition(column, row));

                    if (columnspan > 1)
                        timetableLayoutPanel.SetColumnSpan(newLabel, columnspan);
                }
            }

        }

        private void studentListView_ItemActivate(object sender, EventArgs e)
        {
            

            SavingAndReading data = new SavingAndReading();
            data.ReadSgFile();
            data.ReadTemplateFile();

            removeControls();
            var id = studentListView.SelectedItems[0].SubItems[0].Text;

            foreach(TTTemplateList e1 in SystemList.TemplateList)
            {
                if(e1.StudentList.Exists(r => r.Id.ToString() == id))
                {
                    foreach(WebpageTermTimetable e2 in e1.TttemPlateList)
                    {
                        drawingStudentTT(e2);
                    }
                }
            }

            for (int i = 0; i < SystemList.SessionGroupList.Count(); i++)
            {
                var sg = SystemList.SessionGroupList[i];

                foreach (Student e1 in sg.StudentGroup)
                {
                    if (e1.Id.ToString() == id)
                    {
                        drawingStudentTT(sg.NonLectureSession);
                    }
                }
            }

        }

        private void drawingStudentTT(WebpageTermTimetable e2)
        {
            var moduleShortName = e2.ModuleShortName.Substring(3);
            var roomName = e2.RoomName;
            var lecturerName = findLecturerName(e2.LecturerID);
            var row = e2.Day + 1;
            var column = e2.StartHour - 8;
            var columnspan = e2.EndHour - e2.StartHour;


            Label newLabel = new Label();
            newLabel.Dock = DockStyle.Fill;
            newLabel.Text = roomName + "\n" + moduleShortName + "\n" + lecturerName;
            newLabel.TextAlign = ContentAlignment.MiddleCenter;
            timetableLayoutPanel.Controls.Add(newLabel);
            timetableLayoutPanel.SetCellPosition(newLabel, new TableLayoutPanelCellPosition(column, row));

            if (columnspan > 1)
                timetableLayoutPanel.SetColumnSpan(newLabel, columnspan);
        }

        public void createTemplate()
        {
            SystemList.SessionGroupList.Clear();
            SystemList.TemplateList.Clear();

            int year = 1, term = 1, overlapTimeCollision = 0;
            int practical = 0, tutorial = 0, workshop = 0;
            int totalPracticalSesions = 0;
            int[] dayModules = new int[5];
            //string major = "BSc Computing";
            List<Student> tempStudentList = new List<Student>();
            List<Module> tempModuleList = new List<Module>();
            List<WebpageTermTimetable> tempModuleDetailsList = new List<WebpageTermTimetable>();
            List<WebpageTermTimetable> moduleFullNameList = new List<WebpageTermTimetable>();
            List<WebpageTermTimetable> moduleShortNameList = new List<WebpageTermTimetable>();
            List<WebpageTermTimetable> overlapTimeModuleList = new List<WebpageTermTimetable>();
            List<WebpageTermTimetable> overlapTimeModuleList2 = new List<WebpageTermTimetable>();
            List<WebpageTermTimetable> tempNonOverlapTimeSessionList = new List<WebpageTermTimetable>();
            List<WebpageTermTimetable> tempNonOverlapTimeSessionList2 = new List<WebpageTermTimetable>();
            //List<WebpageTermTimetable> generalTTTemplateList = new List<WebpageTermTimetable>();
            //TTTemplateList generalTTTemplateList = new TTTemplateList();
            
            //List<WebpageTermTimetable> TTTemplateList = new List<WebpageTermTimetable>();
            WebpageTermTimetable[][] tempModuleDetailsArray = new WebpageTermTimetable[5][];
            WebpageTermTimetable[][] tempModuleDetailsArray2 = new WebpageTermTimetable[5][];
            
            List<string> totalPracticalOfEachModuleList = new List<string>();
            List<string> tempStudentTimetableList = new List<string>();
            List<string> practicalList_1 = new List<string>();
            List<string> practicalList_2 = new List<string>();
            List<SessionProperty> spList = new List<SessionProperty>();

            List<SessionGroups> sgList = new List<SessionGroups>();
            List<TTTemplateList> newtttlist = new List<TTTemplateList>();

            List<Student> splitStudentList = new List<Student>();
            
            SavingAndReading data = new SavingAndReading();
            //data.ReadSystemList();
            data.ReadLecturerFile();
            data.ReadModuleFile(data.ModuleFilename);
            data.ReadStudentFile();
            
            //collect the student of a specific year and term 
            tempStudentList = returnStudentList();
            //foreach (Student e1 in SystemList.StudentList)
            //{
            //    if (e1.Grade == year && e1.Term == term)
            //    {
            //        tempStudentList.Add(e1);
            //    }
            //}

            //collect the module of a specific year and term
            foreach (Module e1 in SystemList.ModuleList)
            {
                if (e1.Year == year && e1.Term == term)
                {
                    tempModuleList.Add(e1);
                }
            }

            //collect the module details from termtimetable
            foreach (Module e1 in tempModuleList)
            {
                foreach (WebpageTermTimetable e2 in SystemList.TermTimetableList)
                {
                    if (e1.ModuleFullName == e2.ModuleFullName)
                    {
                        tempModuleDetailsList.Add(e2);
                    }
                }
            }

            for(int i = 0; i < 5; i++)
            {
                int countModules = 0;
                foreach(WebpageTermTimetable e1 in tempModuleDetailsList)
                {
                    if (e1.Day == i)
                        countModules++;
                }

                dayModules[i] = countModules;
            }

            //seperate modules to different days
            
            for(int i = 0; i < 5; i++)
            {
                tempModuleDetailsArray[i] = new WebpageTermTimetable[dayModules[i]];
                tempModuleDetailsArray2[i] = new WebpageTermTimetable[dayModules[i]];
                int j = 0;
                foreach (WebpageTermTimetable e1 in tempModuleDetailsList)
                {
                    if(e1.Day == i)
                    {
                        WebpageTermTimetable newObj = e1;
                        tempModuleDetailsArray[i][j] = newObj;
                        j++;
                    }
                }
            }
            

            //sort modules from 9am to 18pm
            for(int i = 0; i < 5; i++)
            {
                //for(int j = 0; j < tempModuleDetailsArray[i].Count(); j++)
                {
                    tempModuleDetailsArray2[i] = tempModuleDetailsArray[i].OrderBy(r => r.EndHour).ToArray();
                }
            }


            //check if there is a overlap time for sessions or not
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < tempModuleDetailsArray2[i].Count()-1; j++)//module needs to make a comparision with rest of modules, so Count() - 1
                {
                    var original = tempModuleDetailsArray2[i][j];
                    var comparision = tempModuleDetailsArray2[i][j + 1];
                    bool result = false;
                    
                    result = checkSessionsCollision(original, comparision);


                    if (result)
                    {
                        overlapTimeModuleList.Add(original);
                        var anotherSameSession = returnAnotherSameSession(comparision);
                        overlapTimeModuleList.Add(anotherSameSession);
                        overlapTimeCollision++;
                    }
                }
                
            }

            //add abandoned sessions to overlapTimeModuleList
            for(int i = 0; i < (overlapTimeCollision * 2); i++)
            {
                var anotherSameSession = returnAnotherSameSession(overlapTimeModuleList[i]);
                overlapTimeModuleList.Add(anotherSameSession);
            }

            //count total non-lecture session
            //foreach(Module e1 in tempModuleList)
            //{
            //    foreach(WebpageTermTimetable e2 in tempModuleDetailsList)
            //    {
            //        if(e1.ModuleFullName == e2.ModuleFullName && e2.ModuleShortName.Last() != '1')
            //        {
            //            SessionProperty newSp = new SessionProperty();

            //            if (e2.SessinonProperty == "Practical")
            //                practical++;
            //            else if (e2.SessinonProperty == "Tutorial")
            //                tutorial++;
            //            else if (e2.SessinonProperty == "Workshop")
            //                workshop++;

            //            spCount.Add(newSp);
            //        }
            //    }
            //}

            //copy overlapTimeList
            foreach(WebpageTermTimetable e1 in overlapTimeModuleList)
            {
                overlapTimeModuleList2.Add(e1);
            }


            //create general timetable templates
            for(int i = 0; i <= overlapTimeCollision; i++)
            {
                //List<WebpageTermTimetable> generalTTTList = new List<WebpageTermTimetable>();
                TTTemplateList generalTTTemplateList = new TTTemplateList();

                foreach (WebpageTermTimetable e1 in tempModuleDetailsList)
                {
                    if(e1.ModuleShortName.Last() == '1')
                        generalTTTemplateList.TttemPlateList.Add(e1);
                }

                if(overlapTimeModuleList.Count() != 0)
                {
                    for(int j = 0; j < 2; j++)
                    {
                        generalTTTemplateList.TttemPlateList.Add(overlapTimeModuleList[j]);
                    }
                    overlapTimeModuleList.RemoveAt(0);
                    overlapTimeModuleList.RemoveAt(0);
                }

                newtttlist.Add(generalTTTemplateList);
                //MessageBox.Show("test");
            }

            //......................................................................
            //collect non-lecture session and remove overlap time sessions
            //firstly, collect non-lecture sessions
            //RemoveOverlapTimeSessions(tempModuleDetailsList);
            foreach (WebpageTermTimetable e1 in tempModuleDetailsList)
            {
                if (e1.ModuleShortName.Last() != '1')
                    tempNonOverlapTimeSessionList.Add(e1);
            }

            //remove the overlapTime Sessions
            foreach(WebpageTermTimetable e1 in tempNonOverlapTimeSessionList)
            {
                tempNonOverlapTimeSessionList2.Add(e1);
            }

            if (overlapTimeCollision != 0)
            {
                foreach(WebpageTermTimetable e1 in tempNonOverlapTimeSessionList2)
                {
                    foreach(WebpageTermTimetable e2 in overlapTimeModuleList2)
                    {
                        if (e1.ModuleShortName == e2.ModuleShortName)
                            tempNonOverlapTimeSessionList.Remove(e1);
                    }
                }
            }

            //count how many practical, tutorial, and workshop of a module
            foreach (Module e1 in tempModuleList)    
            {
                SessionProperty newSp = new SessionProperty();
                newSp.ModuleFullName = e1.ModuleFullName;

                foreach (WebpageTermTimetable e2 in tempNonOverlapTimeSessionList)
                {
                    if(e2.ModuleFullName == e1.ModuleFullName)
                    {
                        if (e2.SessinonProperty == "Practical")
                            newSp.Practical++;
                        else if (e2.SessinonProperty == "Tutorial")
                            newSp.Tutorial++;
                        else if (e2.SessinonProperty == "Workshop")
                            newSp.Workshop++;
                    }
                }

                spList.Add(newSp);
            }

            

            //.....................................................................
            //split studentList to different groups
            foreach(SessionProperty e1 in spList)
            {
                //SessionGroups newSg = new SessionGroups();
                var sessionCount = sgList.Count();
                int practicalCount = 0, tutorialCount = 0, workshopCount = 0;

                if (e1.Practical != 0)
                {
                    foreach(WebpageTermTimetable e2 in tempNonOverlapTimeSessionList)
                    {
                        if(e2.SessinonProperty == "Practical" && e2.ModuleFullName == e1.ModuleFullName)
                        {
                            SessionGroups newSg = new SessionGroups();
                            newSg.NonLectureSession = e2;
                            sgList.Add(newSg);
                        }
                    }

                    //int i = sessionCount;

                    for (int i = 0; i < e1.Practical; i++)
                    {
                        if (e1.Practical != 1)
                            sgList[practicalCount + sessionCount].StudentGroup = returnSplitStudentList(e1.Practical, i, tempStudentList);
                        else
                            sgList[practicalCount + sessionCount].StudentGroup = tempStudentList;

                        practicalCount++;
                    }

                }

                if(e1.Tutorial != 0)
                {
                    foreach (WebpageTermTimetable e2 in tempNonOverlapTimeSessionList)
                    {
                        if (e2.SessinonProperty == "Tutorial" & e2.ModuleFullName == e1.ModuleFullName)
                        {
                            SessionGroups newSg = new SessionGroups();
                            newSg.NonLectureSession = e2;
                            sgList.Add(newSg);
                        }
                    }

                    //int i = e1.Practical;

                    for (int i = 0; i < e1.Tutorial; i++)
                    {
                        if (e1.Tutorial != 1)
                            sgList[tutorialCount + practicalCount + sessionCount].StudentGroup = returnSplitStudentList(e1.Tutorial, i, tempStudentList);
                        else
                            sgList[tutorialCount + practicalCount + sessionCount].StudentGroup = tempStudentList;

                        tutorialCount++;
                    }
                }

                if (e1.Workshop != 0)
                {
                    foreach (WebpageTermTimetable e2 in tempNonOverlapTimeSessionList)
                    {
                        if (e2.SessinonProperty == "Workshop" & e2.ModuleFullName == e1.ModuleFullName)
                        {
                            SessionGroups newSg = new SessionGroups();
                            newSg.NonLectureSession = e2;
                            sgList.Add(newSg);
                        }
                    }

                    //int i = e1.Practical + e1.Tutorial;

                    for (int i = 0; i < e1.Workshop; i++)
                    {
                        if (e1.Workshop != 1)
                            sgList[workshopCount + tutorialCount + practicalCount + sessionCount].StudentGroup = returnSplitStudentList(e1.Workshop, i, tempStudentList);
                        else
                            sgList[workshopCount + tutorialCount + practicalCount + sessionCount].StudentGroup = tempStudentList;
                        workshopCount++;
                    }
                }

                //MessageBox.Show("test");
            }



            //split studentList to newtttlist
            if(overlapTimeCollision != 0)
            {
                int count = 0;

                foreach (TTTemplateList e1 in newtttlist)
                {
                    e1.StudentList = returnSplitStudentList(overlapTimeCollision + 1, count, tempStudentList);
                    count++;
                }
            }

            //data.WriteSgFile();
            //data.WriteTemplate();
            //data.WriteSystemList();
            //copy newtttlist and newSg
            foreach (TTTemplateList e1 in newtttlist)
            {
                SystemList.TemplateList.Add(e1);
            }

            foreach (SessionGroups e1 in sgList)
            {
                SystemList.SessionGroupList.Add(e1);
            }
            //MessageBox.Show("test");
            data.WriteSgFile();
            data.WriteTemplate();
        }

        public WebpageTermTimetable returnAnotherSameSession(WebpageTermTimetable abandonSession)
        {
            SavingAndReading data = new SavingAndReading();
            data.ReadTermTimetableFile();

            foreach(WebpageTermTimetable e1 in SystemList.TermTimetableList)
            {
                //if(abandonSession != e1)
                {
                    if (e1.ModuleShortName != abandonSession.ModuleShortName && e1.ModuleFullName == abandonSession.ModuleFullName && e1.SessinonProperty == abandonSession.SessinonProperty)
                    {
                        return e1;
                    }
                }
                
            }
            return null;
        }

        public bool checkSessionsCollision(WebpageTermTimetable original, WebpageTermTimetable comparision)
        {
            List<int> originalTimeNum = new List<int>();
            List<int> comparisionTimeNum = new List<int>();
            bool repeatNum = false;


            originalTimeNum = returnNumberList(original.StartHour, original.EndHour);
            comparisionTimeNum = returnNumberList(comparision.StartHour, comparision.EndHour);

            repeatNum = checkRepeatNumber(originalTimeNum, comparisionTimeNum);

            if (original.EndHour == comparision.StartHour && original.EndMin <= comparision.StartMin)
                repeatNum = false;

            return repeatNum;
        }

        public List<int> returnNumberList(int startHour, int endHour)
        {
            List<int> numbers = new List<int>();
            int difference = endHour - startHour;

            numbers.Add(startHour);

            if (difference == 3)
                difference = 2;

            for (int i = 1; i <= difference; i++)
            {
                numbers.Add(startHour + i);
            }

            return numbers;
        }

        //check if the two numberLists have the same number, if yes then return true
        public bool checkRepeatNumber(List<int> numList_1, List<int> numList_2)
        {
            bool sameNum = false;

            foreach (int e1 in numList_1)
            {
                foreach (int e2 in numList_2)
                {
                    if (e1 == e2)
                    {
                        return true;
                    }
                }
            }

            return sameNum;
        }

        private List<Student> returnStudentList()
        {
            List<Student> tempStudentList = new List<Student>();

            foreach (Student e1 in SystemList.StudentList)
            {
                char yearX = e1.Id.ToString()[0];
                char yearY = e1.Id.ToString()[1];
                string year = string.Format("{0}{1}", yearX, yearY);

                if (year == yearXText + yearYText && e1.Degree == degree && e1.Grade == grade && e1.Term == term)
                {
                    tempStudentList.Add(e1);
                }
            }

            return tempStudentList;
        }

        //private List<Module> returnTempModuleList()
        //{
        //    List<Module> tempModuleList = new List<Module>();

        //    foreach (Module e1 in SystemList.ModuleList)
        //    {

        //        if (e1.Year == year && e1.Term == term)
        //        {
        //            tempModuleList.Add(e1);
        //        }
        //    }

        //    return tempModuleList;
        //}

        //private void createSessionGroups()
        //{
        //    for
        //}

        //private WebpageTermTimetable RemoveOverlapTimeSessions(WebpageTermTimetable tempModuleListDetails)
        //{
        //    foreach(WebpageTermTimetable e1 in tempModuleListDetails)
        //    {

        //    }

        //    return tempModuleListDetails;
        //}

        private List<Student> returnSplitStudentList(int totalSessionProperty, int returnPart, List<Student> tempStudentList)
        {
            List<Student> splitStudentList = new List<Student>();
            int totalStudents;
            int startPosition, endPostion;

            totalStudents = tempStudentList.Count() / totalSessionProperty;
            startPosition = totalStudents * returnPart;
            endPostion = totalStudents * returnPart + totalStudents;

            //if(returnPart != totalSessionProperty)
            //{
            //    for(int i = 0; i)
            //}

            if ((returnPart + 1) != totalSessionProperty)
            {
                int i = startPosition;

                for (; i < endPostion; i++)
                {
                    splitStudentList.Add(tempStudentList[i]);
                }

            }else
            {
                int i = startPosition;

                for (; i < tempStudentList.Count; i++ )
                {
                    splitStudentList.Add(tempStudentList[i]);
                }
            }
            return splitStudentList;
        }

        private void AddSubjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                SavingAndReading save = new SavingAndReading();
                save.WriteSystemList();
            }else
            {
                e.Cancel = true;
            }
        }
    }
}
