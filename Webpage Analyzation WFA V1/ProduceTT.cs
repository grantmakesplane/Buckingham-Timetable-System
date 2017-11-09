using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML;
using ClosedXML.Excel;
using System.IO;

namespace Webpage_Analyzation_WFA_V1
{
    class ProduceTT
    {
        private string header;
        private string subHeader;
        private List<XLColor> colorList = new List<XLColor>() { XLColor.Red, XLColor.Green, XLColor.Blue, XLColor.Gold,  XLColor.Gray
    };
        private List<string> colorSelectionList;
        private int colorSeleced;
        int colorIndex;

        public ProduceTT()
        {
            Header = "";
            SubHeader = "";
            ColorList = new List<XLColor>() { XLColor.Red, XLColor.Green, XLColor.Blue, XLColor.Gold,  XLColor.Gray };
            ColorSeleced = 0;
            ColorSelectionList = new List<string>();
        }

        public string Header
        {
            get
            {
                return header;
            }

            set
            {
                header = value;
            }
        }

        public string SubHeader
        {
            get
            {
                return subHeader;
            }

            set
            {
                subHeader = value;
            }
        }

        public List<XLColor> ColorList
        {
            get
            {
                return colorList;
            }

            set
            {
                colorList = value;
            }
        }

        public List<string> ColorSelectionList
        {
            get
            {
                return colorSelectionList;
            }

            set
            {
                colorSelectionList = value;
            }
        }

        public int ColorSeleced
        {
            get
            {
                return colorSeleced;
            }

            set
            {
                colorSeleced = value;
            }
        }

        public int ColorIndex
        {
            get
            {
                return colorIndex;
            }

            set
            {
                colorIndex = value;
            }
        }

        public void produceStudentTimetable(string yearX, string yearY, int degree, int grade, int term)
        {
            string docName = "TimetableTemplate.xlsx";
            int position = 0, hour = 1, count = 0;
            SavingAndReading data = new SavingAndReading();
            data.ReadSgFile();
            data.ReadTemplateFile();
            data.ReadTermTimetableFile();

            //collect tempstudent
            List<Student> tempStudentList = new List<Student>();
            foreach(Student e1 in SystemList.StudentList)
            {
                string x = e1.Id.ToString()[0].ToString();
                string y = e1.Id.ToString()[1].ToString();

                if (x == yearX && y == yearY && e1.Degree == degree && e1.Grade == grade && e1.Term == term)
                {
                    tempStudentList.Add(e1);
                }
            }

            foreach(Student e1 in tempStudentList)
            {
                var workbook = new XLWorkbook(docName);
                var ws = workbook.Worksheet(1);

                foreach (TTTemplateList e2 in SystemList.TemplateList)
                {
                    if(e2.StudentList.Exists(r => r.Id == e1.Id))
                    {
                        foreach(WebpageTermTimetable e3 in e2.TttemPlateList)
                        {
                            

                            var subHearder = e1.FirstName + e1.LastName;
                            var moduleFullName = e3.ModuleFullName;
                            var moduleShortName = e3.ModuleShortName.Substring(2);
                            var roomName = e3.RoomName;
                            var lecturerName = findLecturerName(e3.LecturerID);
                            hour = e3.EndHour - e3.StartHour;

                            insertTextToSubHeader(subHearder, ws);

                            var startPosition = string.Format("{0}{1}", (char)(e3.StartHour - 9 + 66), (e3.Day + 4));
                            var endPosition = string.Format("{0}{1}", (char)(e3.StartHour - 9 + 66 + hour - 1), (e3.Day + 4));
                            //if a module over one hour then merge the cells
                            if (hour > 1)
                            {
                                mergeCells(startPosition, endPosition, ws);

                                insertDetailsToCells(roomName, moduleShortName, lecturerName, ws, startPosition, endPosition);
                            }
                            else
                            {
                                insertDetailsToCells(roomName, moduleShortName, lecturerName, ws, startPosition, endPosition);
                            }

                        }
                    }
                }

                createFolder();
                string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Timetable System");

                workbook.SaveAs(path + "\\StudentTimetable\\" + e1.FirstName + e1.LastName + ".xlsx");
            }

            foreach(Student e1 in tempStudentList)
            {
                string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Timetable System");
                docName = path + "\\StudentTimetable\\" + e1.FirstName + e1.LastName + ".xlsx";

                var workbook = new XLWorkbook(docName);
                var ws = workbook.Worksheet(1);
                foreach (SessionGroups e2 in SystemList.SessionGroupList)
                {
                    foreach (Student e3 in e2.StudentGroup)
                    {
                        if (e3.Id == e1.Id)
                        {

                            var moduleFullName = e2.NonLectureSession.ModuleFullName;
                            var moduleShortName = e2.NonLectureSession.ModuleShortName.Substring(2);
                            var roomName = e2.NonLectureSession.RoomName;
                            var lecturerName = findLecturerName(e2.NonLectureSession.LecturerID);
                            hour = e2.NonLectureSession.EndHour - e2.NonLectureSession.StartHour;

                            var startPosition = string.Format("{0}{1}", (char)(e2.NonLectureSession.StartHour - 9 + 66), (e2.NonLectureSession.Day + 4));
                            var endPosition = string.Format("{0}{1}", (char)(e2.NonLectureSession.StartHour - 9 + 66 + hour - 1), (e2.NonLectureSession.Day + 4));
                            //if a module over one hour then merge the cells
                            if (hour > 1)
                            {
                                mergeCells(startPosition, endPosition, ws);

                                insertDetailsToCells(roomName, moduleShortName, lecturerName, ws, startPosition, endPosition);
                            }
                            else
                            {
                                insertDetailsToCells(roomName, moduleShortName, lecturerName, ws, startPosition, endPosition);
                            }
                        }
                    }
                }

                workbook.Save();
            }
            



        }

        public void prodceLecturer()
        {
            string docName = "TimetableTemplate.xlsx";
            int position = 0, hour = 1, count = 0;
            SavingAndReading data = new SavingAndReading();
            data.ReadSgFile();
            data.ReadTemplateFile();
            data.ReadTermTimetableFile();

            foreach(Lecturer e1 in SystemList.LecturerList)
            {
                var workbook = new XLWorkbook(docName);
                var ws = workbook.Worksheet(1);
                foreach (WebpageTermTimetable e2 in SystemList.TermTimetableList)
                {
                    if(e1.Id == e2.LecturerID)
                    {
                        var subHearder = e1.FirstName + e1.LastName;
                        var moduleFullName = e2.ModuleFullName;
                        var moduleShortName = e2.ModuleShortName.Substring(2);
                        var roomName = e2.RoomName;
                        var lecturerName = findLecturerName(e2.LecturerID);
                        hour = e2.EndHour - e2.StartHour;

                        insertTextToSubHeader(subHearder, ws);

                        var startPosition = string.Format("{0}{1}", (char)(e2.StartHour - 9 + 66), (e2.Day + 4));
                        var endPosition = string.Format("{0}{1}", (char)(e2.StartHour - 9 + 66 + hour - 1), (e2.Day + 4));
                        //if a module over one hour then merge the cells
                        if (hour > 1)
                        {
                            mergeCells(startPosition, endPosition, ws);

                            insertDetailsToCells(roomName, moduleShortName, lecturerName, ws, startPosition, endPosition);
                        }
                        else
                        {
                            insertDetailsToCells(roomName, moduleShortName, lecturerName, ws, startPosition, endPosition);
                        }


                    }
                }
                createFolder();
                string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Timetable System");

                workbook.SaveAs(path + "\\LecturerTimetable\\" + e1.FirstName + e1.LastName + ".xlsx");
            }
        }



        public void produceRoomTimetable()
        {
            int position = 0, hour = 1, count = 0;
            //string moduleFullName, moduleShortName, roomName, lecturerName = "", startPosition, endPosition;
            WebpageTermTimetable ttDetails = new WebpageTermTimetable();

            SavingAndReading data = new SavingAndReading();
            //data.ReadSystemList();

            string docName = "TimetableTemplate.xlsx";
            //var workbook = new XLWorkbook(docName);
            //var ws = workbook.Worksheet(1);

            List<Room> tempRoomList = new List<Room>();
            data.ReadRoomFile("room.xml");
            tempRoomList = SystemList.RoomsList;
            data.ReadSystemList();

            

            //start to select each object from roomsList and print details
            foreach (Room e1 in SystemList.RoomsList)
            {

                var workbook = new XLWorkbook(docName);
                var ws = workbook.Worksheet(1);
                //if (e1.RoomName == tempRoomList[count].RoomName)
                {
                    subHeader = e1.RoomName;

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (e1.TtDimensionArray[i][j].HasSubject == true)
                            {
                                position = e1.TtDimensionArray[i][j].TermTTListPosition;
                                ttDetails = SystemList.TermTimetableList[position];

                                var moduleFullName = ttDetails.ModuleFullName;
                                var moduleShortName = ttDetails.ModuleShortName;
                                var roomName = ttDetails.RoomName;
                                var lecturerName = findLecturerName(ttDetails.LecturerID);
                                hour = ttDetails.EndHour - ttDetails.StartHour;
                                //start inserting details for each timetable


                                //ProduceTT ptt = new ProduceTT();

                                //change the subHeader
                                insertTextToSubHeader(roomName, ws);

                                var startPosition = string.Format("{0}{1}", (char)(j + 66), (i + 4));
                                var endPosition = string.Format("{0}{1}", (char)(j + 66 + hour - 1), (i + 4));
                                //if a module over one hour then merge the cells
                                if (hour > 1)
                                {
                                    mergeCells(startPosition, endPosition, ws);

                                    insertDetailsToCells(moduleFullName, moduleShortName, lecturerName, ws, startPosition, endPosition);
                                }
                                else
                                {
                                    insertDetailsToCells(moduleFullName, moduleShortName, lecturerName, ws, startPosition, endPosition);
                                }

                            }
                        }
                        createFolder();
                        string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Timetable System");

                        workbook.SaveAs(path + "\\Timetable\\" + e1.RoomName + ".xlsx");
                    }
                    colorSelectionList.Clear();
                    count++;
                }
            }
        }

        public void mergeCells(string startPosition, string endPosition, IXLWorksheet ws)
        {
            var rngTable = ws.Range("A1:J8");

            rngTable.Range(startPosition + ":" + endPosition).Merge();


        }

        public void insertTextToSubHeader(string subHeader, IXLWorksheet ws)
        {
            ws.Cell("A2").Value = subHeader;
        }

        public void insertDetailsToCells(string text, string moduleShortName, string lecturerName, IXLWorksheet ws, string startPosition, string endPosition)
        {
            //int moduleColorIndex =  ColorSelectionList.FindIndex(r => r == moduleFullName);
            
            //var rngTable = ws.Range("A1:J8");
            //var rngCell = rngTable.Range(startPosition, endPosition);
            var rngCell = ws.Range(startPosition + ":" + endPosition);
            ws.Cell(startPosition).Style.Alignment.WrapText = true;

            //if (moduleColorIndex != -1)
            {
                //ws.Cell(startPosition).Value = moduleShortName + "\n" + lecturerName;
                //rngCell.Style.Font.FontColor = ColorList[moduleColorIndex];
                //Console.WriteLine(ColorList[moduleColorIndex]);
            }
            //else
            {
                //select one color and send it to ColorSelectionList   
                //ColorSelectionList.Add(moduleFullName);
                ws.Cell(startPosition).Value = moduleShortName + "\n" + lecturerName + "\n" + text;
                //ColorIndex = ColorSelectionList.Count() - 1;
                //rngCell.Style.Font.FontColor = ColorList[colorIndex];
                //rngCell.Style.Font.SetFontColor(ColorList[ColorSelectionList.Count() - 1]);
                //Console.WriteLine(startPosition + " " + endPosition + " " + ColorList[ColorSelectionList.Count() - 1]);
            }
        }

        public string findLecturerName(int lecturerID)
        {
            string lecturerName = "";

            foreach(Lecturer e1 in SystemList.LecturerList)
            {
                if (e1.Id == lecturerID)
                    lecturerName = (e1.FirstName + e1.MiddleName + e1.LastName);
            }

            return lecturerName;
        }

        public bool checkLecturePracticalCollision(List<WebpageTermTimetable> lecture, List<WebpageTermTimetable> practical)
        {
            List<int> lectureTimeNum = new List<int>();
            List<int> practicalTimeNum = new List<int>();
            bool repeatNum = false;

            foreach(WebpageTermTimetable e1 in lecture)
            {
                lectureTimeNum = returnNumberList(e1.StartHour, e1.EndHour);
            }

            foreach (WebpageTermTimetable e2 in practical)
            {
                practicalTimeNum = returnNumberList(e2.StartHour, e2.EndHour);

            }

            repeatNum = checkRepeatNumber(lectureTimeNum, practicalTimeNum);

            return repeatNum;
        }

        public List<int> returnNumberList(int startHour, int endHour)
        {
            List<int> numbers = new List<int>();
            int difference = startHour - endHour;

            numbers.Add(startHour);

            for(int i = 0; i <difference; i++ )
            {
                numbers.Add(startHour + i);
            }

            return numbers;
        }

        //check if the two numberLists have the same number, if yes then return true
        public bool checkRepeatNumber(List<int> numList_1, List<int> numList_2)
        {
            bool sameNum = false;

            foreach(int e1 in numList_1)
            {
                foreach(int e2 in numList_2)
                {
                    if(e1 == e2)
                    {
                        return true;
                    }
                }
            }

            return sameNum;
        }



        public void createFolder()
        {
            string folder = "Timetable System\\Timetable";

            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), folder);

            if (!System.IO.Directory.Exists(path))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                catch (IOException ie)
                {
                    Console.WriteLine("IO Error: " + ie.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("General Error: " + e.Message);
                }
            }
        }
    }


}
