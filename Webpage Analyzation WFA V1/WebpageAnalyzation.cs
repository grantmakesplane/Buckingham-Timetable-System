using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Webpage_Analyzation_WFA_V1
{
    class WebpageAnalyzation
    {
        List<WebpageTime> timeContainer = new List<WebpageTime>();
        List<WebpageSubject> subjectContainer = new List<WebpageSubject>();
        List<WebpageTimeTable> timetableContainer = new List<WebpageTimeTable>();

        public void WebpageAnalyzationMain(string filename)
        {
            SavingAndReading data = new SavingAndReading();

            string url = System.IO.File.ReadAllText(filename);
            WebpageAnalyzation web = new WebpageAnalyzation();

            HtmlDocument doc = web.DepartmentNodeCollection(url);

            web.timePX(doc);
            web.Subject(doc);
            web.CountSubjectInEachDay(doc);
            web.CompeletTT(doc);
            web.print();

            data.WriteSystemList();
        }


        public HtmlDocument DepartmentNodeCollection(string departmentHtml)
        {
            HtmlDocument doc = new HtmlDocument();

            doc.LoadHtml(departmentHtml);

            return doc;
        }


        /// <summary>
        /// read each hour position
        /// </summary>
        /// <param name="doc"></param>
        public void timePX(HtmlDocument doc)
        {
            HtmlNodeCollection timePositionNode = doc.DocumentNode.SelectNodes("//div[@class='ts2']");
            HtmlNode timePXNode;

            int[] validNum = new int[8];
            int readElementInTotal = 4;

            for (int readElement = 2; readElement <= 10; readElement++)
            {
                timePXNode = timePositionNode[readElement];

                string timeStyle = timePXNode.Attributes["style"].Value;

                validNum = ValidNumbers(timeStyle, readElementInTotal);

                //send these nodes to time list
                WebpageTime timelist = new WebpageTime();

                timelist.LeftPX = int.Parse(timeStyle.Substring(validNum[0], validNum[1]));
                timelist.TopPX = int.Parse(timeStyle.Substring(validNum[2], validNum[3]));
                timelist.WidthPX = int.Parse(timeStyle.Substring(validNum[4], validNum[5]));
                timelist.HeightPX = int.Parse(timeStyle.Substring(validNum[6], validNum[7]));
                timeContainer.Add(timelist);

            }


            //Console.WriteLine("\n\n\n");
        }//end of timePX method

        public int[] ValidNumbers(string style, int readElementInTotal)
        {
            int[] validNum = new int[8]; //first element is start position, next one is how many valid number it has, so do I need to use double array
            int validNumCount = 0;
            int countNum = 0; //count how many number of each left, right, height, top has
            int countColumn = 0;
            char[] char_timePXNode = style.ToArray();

            for (int findNum = 0; findNum < char_timePXNode.Length; findNum++)
            {
                //after find ':', save next position to validnum array
                if (char_timePXNode[findNum] == ':')
                {
                    validNum[validNumCount] = ++findNum;
                    validNumCount++; //move to next position to storage total valid number

                    while (char_timePXNode[findNum] != 'p')
                    {
                        countNum++;
                        findNum++;
                    }
                    validNum[validNumCount] = countNum;
                    countNum = 0; //initialize countNum to 0
                    validNumCount++; //move to next position to storage total valid number
                    countColumn++;
                }

                if (countColumn == readElementInTotal)
                {
                    break;
                }
            }

            return validNum;
        }//end of ValidNumbers method

        public void Subject(HtmlDocument doc)
        {
            HtmlNodeCollection subjectStyleNode = doc.DocumentNode.SelectNodes("//div[contains(@id,'div0event')]");
            HtmlNodeCollection subjectDetailsNode = doc.DocumentNode.SelectNodes("//div[contains(@id,'div0event')]//b");
            //HtmlNodeCollection testNode = doc.DocumentNode.SelectNodes("//div[contains(@id,'div0event')]//b//br");

            HtmlNode subjectSingleNode;

            int[] validNum = new int[8];
            int readElementInTotal = 3;

            for (int readElement = 0; readElement < subjectStyleNode.Count(); readElement++)
            {
                subjectSingleNode = subjectStyleNode[readElement];
                string subjectStyle = subjectSingleNode.Attributes["style"].Value;

                string subjectShortName = subjectDetailsNode[readElement].InnerHtml;
                string subjectFullName = subjectDetailsNode[readElement].SelectSingleNode("following-sibling::text()[1]").InnerText;
                string subjectRoomAndSize = subjectDetailsNode[readElement].SelectSingleNode("following-sibling::text()[2]").InnerText;

                string subjectRoomName = "";
                int subjectRoomSize = 0;
                int subjectRoomSizeTaken = 0;

                SeperateRoomAndSize(subjectRoomAndSize, ref subjectRoomName, ref subjectRoomSize, ref subjectRoomSizeTaken);

                //analyze the position of each subject, and details of each subject
                validNum = ValidNumbers(subjectStyle, readElementInTotal);

                //send these nodes to subject list
                WebpageSubject subjectList = new WebpageSubject();

                subjectList.LeftPX = int.Parse(subjectStyle.Substring(validNum[0], validNum[1]));
                subjectList.TopPX = int.Parse(subjectStyle.Substring(validNum[2], validNum[3]));
                subjectList.WidthPX = int.Parse(subjectStyle.Substring(validNum[4], validNum[5]));

                //send subject details to subject list
                subjectList.SubjectFullName = subjectFullName;
                subjectList.SubjectShortName = subjectShortName;

                subjectList.RoomName = subjectRoomName;
                subjectList.RoomSize = subjectRoomSize;
                subjectList.RoomSizeTaken = subjectRoomSizeTaken;

                subjectContainer.Add(subjectList);
                //Console.Write(subjectContainer[0].RoomName);

            }



            //foreach (HtmlNode items in subjectNode)
            //{
            //    Console.WriteLine(items.InnerHtml);
            //    Console.WriteLine(t);
            //}

        }


        public int[] CountSubjectInEachDay(HtmlDocument doc)
        {
            int day0 = 0, day1 = 0, day2 = 0, day3 = 0, day4 = 0;
            int[] dayArray = { day0, day1, day2, day3, day4 };
            HtmlNodeCollection day0Node, day1Node, day2Node, day3Node, day4Node;
            //HtmlNodeCollection[] dayNodeArray = { day0Node, day1Node, day2Node, day3Node, day4Node };

            day0Node = doc.DocumentNode.SelectNodes("//div[contains(@id,'day0') and contains(@class, 'e3')]");
            day1Node = doc.DocumentNode.SelectNodes("//div[contains(@id,'day1') and contains(@class, 'e3')]");
            day2Node = doc.DocumentNode.SelectNodes("//div[contains(@id,'day2') and contains(@class, 'e3')]");
            day3Node = doc.DocumentNode.SelectNodes("//div[contains(@id,'day3') and contains(@class, 'e3')]");
            day4Node = doc.DocumentNode.SelectNodes("//div[contains(@id,'day4') and contains(@class, 'e3')]");

            HtmlNodeCollection[] dayNodeArray = { day0Node, day1Node, day2Node, day3Node, day4Node };

            //dayNodeArray = { day0Node, day1Node, day2Node, day3Node, day4Node };

            for (int readElement = 0; readElement < 5; readElement++)
            {
                if (dayNodeArray[readElement] == null)
                {
                    dayArray[readElement] = 0;
                }
                else
                {
                    dayArray[readElement] = dayNodeArray[readElement].Count;
                }

            }


            //HtmlNodeCollection dayNode = doc.DocumentNode.SelectNodes("//div[contains(@id,'div0day')]");
            //HtmlNodeCollection dayNode = doc.DocumentNode.SelectNodes("//div[contains(@id,'day1') and contains(@class, 'e3')]");
            //day0 = doc.DocumentNode.SelectNodes("//div[contains(@id,'day0') and contains(@class, 'e3')]").Count == null ? 0 : ;
            //day1 = doc.DocumentNode.SelectNodes("//div[contains(@id,'day1') and contains(@class, 'e3')]").Count;
            //day2 = doc.DocumentNode.SelectNodes("//div[contains(@id,'day2') and contains(@class, 'e3')]").Count;
            //day3 = doc.DocumentNode.SelectNodes("//div[contains(@id,'day3') and contains(@class, 'e3')]").Count;
            //day4 = doc.DocumentNode.SelectNodes("//div[contains(@id,'day4') and contains(@class, 'e3')]").Count;

            //int[] daySubjects = { day0, day1, day2, day3, day4 };
            //Console.Write("Moday: {0}, Tuesday: {1}, Wenesday: {2}, Thursday: {3}, Friday: {4}", day0, day1, day2, day3, day4);

            return dayArray;
            //HtmlNode daySingleNode;


            //Console.WriteLine(t);
            //for (int readElement = 0; readElement < dayNode.Count(); readElement++)
            //{
            //    daySingleNode = dayNode[readElement];
            //    string dayStyle = daySingleNode.Attributes["style"].Value;

            //    //Console.WriteLine(daySingleNode.InnerHtml);

            //    Console.WriteLine("{0}\n", dayStyle);


            //}


            //foreach(HtmlNode items in dayNode)
            //{
            //    Console.WriteLine(items.InnerHtml);

            //}
        }

        public void SeperateRoomAndSize(string subjectRoomAndSize, ref string subjectRoomName, ref int subjectRoomSize, ref int subjectRoomSizeTaken)
        {
            char[] char_array_subjectRoomAndSize = subjectRoomAndSize.ToArray();
            int totalClose = 0;
            int lastLeftClose = 0;
            int forwardSlash = 0;
            //string subjectRoomName;
            //int subjectRoomSize;
            //List <string, int> = new List<>();
            //string roomName;
            //int roomSize;

            for (int readElement = 0; readElement < char_array_subjectRoomAndSize.Length; readElement++)
            {
                if (char_array_subjectRoomAndSize[readElement] == '(')
                {
                    lastLeftClose = readElement;
                    totalClose++;
                }

                if (char_array_subjectRoomAndSize[readElement] == '/')
                {
                    forwardSlash = readElement;
                }
            }

            subjectRoomName = subjectRoomAndSize.Substring(0, lastLeftClose - 1);
            subjectRoomSize = int.Parse(subjectRoomAndSize.Substring(forwardSlash + 1, (char_array_subjectRoomAndSize.Length - 1) - (forwardSlash + 1)));
            subjectRoomSizeTaken = int.Parse(subjectRoomAndSize.Substring(lastLeftClose + 1, ((forwardSlash - 1) - lastLeftClose)));

        }

        public void CompeletTTT(HtmlDocument doc)
        {
            int[] daySubject = CountSubjectInEachDay(doc);
            int dayCount = 0;
            int part, block;
            int readSubjects = 0;

            for (readSubjects = 0; readSubjects < subjectContainer.Count; readSubjects++)
            {
                for (int readTime = 0; readTime < timeContainer.Count; readTime++)
                {
                    if (subjectContainer[readSubjects].LeftPX <= timeContainer[readTime].LeftPX)
                    {
                        WebpageTimeTable tt = new WebpageTimeTable();

                        if (readSubjects < daySubject[dayCount])
                            tt.Day = dayCount;
                        else
                        {
                            dayCount++;
                            tt.Day = dayCount;
                        }
                        readTime--;
                        //each 18px represents 15 mins in one cell, therefore 4 parts, each 75px, represents 1 hour
                        part = (subjectContainer[readSubjects].LeftPX - timeContainer[readTime].LeftPX) / 18;
                        //Console.WriteLine(part);
                        block = subjectContainer[readSubjects].WidthPX / 73;
                        //Console.WriteLine();
                        //tt.Day = readDaySubjectsCount;
                        //tt.Day = 
                        tt.StartHour = readTime + 9;
                        tt.StartMin = tt.EndMin = part * 15;
                        tt.EndHour = tt.StartHour + block;
                        tt.SubjectFullName = subjectContainer[readSubjects].SubjectFullName;
                        tt.SubjectShortName = subjectContainer[readSubjects].SubjectShortName;
                        tt.RoomName = subjectContainer[readSubjects].RoomName;
                        tt.RoomSize = subjectContainer[readSubjects].RoomSize;
                        tt.RoomSizeTaken = subjectContainer[readSubjects].RoomSizeTaken;


                        timetableContainer.Add(tt);
                        //Console.WriteLine("test: {0}\n", timetableContainer[readSubjects].SubjectFullName);

                        break;
                    }
                }
                //break;
            }
        }

        public void CompeletTT(HtmlDocument doc)
        {
            int[] daySubject = CountSubjectInEachDay(doc);
            int dayCount = 0, readSubjectsCount = 0; ;
            //int readDaySubjectsCount = 0;
            int part, block;



            //for (int readDaySubjects = 0; readDaySubjects < daySubject[readDaySubjectsCount]; readDaySubjects++)
            {
                for (int readSubjects = 0; readSubjects < subjectContainer.Count; readSubjects++)
                {
                    for (int readTime = 0; readTime < timeContainer.Count; readTime++)
                    {
                        if (subjectContainer[readSubjects].LeftPX <= timeContainer[readTime].LeftPX)
                        {
                            WebpageTimeTable tt = new WebpageTimeTable();
                            //Console.WriteLine("subject: {0}", subjectContainer[readSubjects].SubjectFullName);
                            readTime--;
                            //each 18px represents 15 mins in one cell, therefore 4 parts, each 75px, represents 1 hour
                            part = (subjectContainer[readSubjects].LeftPX - timeContainer[readTime].LeftPX) / 18;
                            //Console.WriteLine(part);
                            block = subjectContainer[readSubjects].WidthPX / 73;
                            //Console.WriteLine();
                            //tt.Day = readDaySubjectsCount;
                            //tt.Day = 
                            tt.StartHour = readTime + 9;
                            tt.StartMin = tt.EndMin = part * 15;
                            tt.EndHour = tt.StartHour + block;
                            tt.SubjectFullName = subjectContainer[readSubjects].SubjectFullName;
                            tt.SubjectShortName = subjectContainer[readSubjects].SubjectShortName;
                            tt.RoomName = subjectContainer[readSubjects].RoomName;
                            tt.RoomSize = subjectContainer[readSubjects].RoomSize;
                            tt.RoomSizeTaken = subjectContainer[readSubjects].RoomSizeTaken;


                            //can not use 3 for loops, so I choose another way to define a day of each subject
                            if (readSubjectsCount < daySubject[dayCount])
                            {
                                tt.Day = dayCount;
                                readSubjectsCount++;
                            }
                            else
                            {
                                dayCount++;
                                tt.Day = dayCount;
                                readSubjectsCount = 1;
                            }

                            timetableContainer.Add(tt);
                            //Console.WriteLine("test: {0}\n", timetableContainer[readSubjects].SubjectFullName);

                            break;
                        }
                    }
                    //break;
                }
                //readDaySubjectsCount++;
                // if (readDaySubjectsCount > 5)
                {
                    //   break;
                }

                //readDaySubjects = 0;
            }
            //    foreach(TimeTable t in timetableContainer)
            //{
            //    Console.Write("t: {0}", t.SubjectFullName);
            //}
            //TimeTable test = new TimeTable();
            //test = timetableContainer[1];
            //Console.WriteLine("Subject Full Name: {0} \nSuject Short Name: {1}", test.SubjectFullName, test.SubjectShortName);

            //foreach (TimeTable cells in timetableContainer)
            //{
            //    Console.Write("Day: {0} startHour: {1} : {2} endHour: {3} endMin: {4}", cells.Day, cells.StartHour, cells.StartMin, cells.EndMin);
            //}

            //print();
        }//end of CompeletTT method

        public void print()
        {
            WebpageTimeTable test = new WebpageTimeTable();

            


            foreach (WebpageTimeTable t in timetableContainer)
            {
                WebpageTermTimetable newWebpageTermTimetable = new WebpageTermTimetable();
                newWebpageTermTimetable.Day = t.Day;
                newWebpageTermTimetable.RoomName = t.RoomName;
                newWebpageTermTimetable.RoomSize = t.RoomSize;
                newWebpageTermTimetable.StartHour = t.StartHour;
                newWebpageTermTimetable.StartMin = t.StartMin;
                newWebpageTermTimetable.EndHour = t.EndHour;
                newWebpageTermTimetable.EndMin = t.EndMin;
                newWebpageTermTimetable.ModuleFullName = t.SubjectFullName;
                newWebpageTermTimetable.ModuleShortName = t.SubjectShortName;
                newWebpageTermTimetable.SessinonProperty = "Lecture";

                SavingAndReading data = new SavingAndReading();
                data.ReadModuleFile("module.xml");

                var i = SystemList.ModuleList.FindIndex(r => r.ModuleFullName == t.SubjectFullName) + 1;

                

                foreach (Module e1 in SystemList.ModuleList)
                {
                    if (e1.ModuleFullName == t.SubjectFullName || e1.ModuleShortName == t.SubjectShortName)
                    {
                        newWebpageTermTimetable.LecturerID = e1.LecturerID;
                        //Console.WriteLine(e1.ModuleFullName, "   ***   ", t.SubjectFullName);
                    }

                }

                SystemList.TermTimetableList.Add(newWebpageTermTimetable);
            }

        }

    }//end of class
}
