using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Webpage_Analyzation_WFA_V1
{
    public class Room
    {
        public int RoomSize { get; set; }
        //private int roomID;
        public string RoomName { get; set; }

        

        public TimetableCells TtCells1
        {
            get
            {
                return TtCells;
            }

            set
            {
                TtCells = value;
            }
        }

        public TimetableCells[][] TtDimensionArray
        {
            get
            {
                return ttDimensionArray;
            }

            set
            {
                ttDimensionArray = value;
            }
        }



        //private List<int[,]> cells = new List<int[,]>();
        private TimetableCells TtCells;

        private TimetableCells[][] ttDimensionArray;
        //private  List<string> moduleName;
        //private int[,] cells = new int[5,9];
        //private TimetableCells cell;
        //private TimeCellHours timeCell;
        //private Lecturer lecturerID;
        //private Module moduleID;

        public Room()
        {
            RoomSize = 20;
            RoomName = "";
            TtDimensionArray = new TimetableCells[5][];

            for (int i = 0; i < 5; i++)
            {
                ttDimensionArray[i] = new TimetableCells[9];
                for (int j = 0; j < 9; j++)
                {
                    TimetableCells newttCells = new TimetableCells();

                    TtDimensionArray[i][j] = newttCells;
                }
            }
        }
        //create a dimensional TimetableCells list "ttDimensionList" and compose TimetableCells ttCells;
        //save ttCells into ttDimensionList
        public Room defaultValue(Room newRoom)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TimetableCells newttCells = new TimetableCells();
                    newRoom.TtDimensionArray[i][j]=newttCells;
                }
            }

            //SystemList.RoomsList.Add(newRoom);
            return newRoom;
        }

        

        public void roomMain()
        {
            int choice;
            SavingAndReading data = new SavingAndReading();
            Room newRoom = new Room();

            while (true)
            {

            Console.WriteLine("\n1. Add A Room \n2. Print A Room \n3. Print All Room \n4. Collect Room Info");
            choice = int.Parse(Console.ReadLine());


            
                switch (choice)
                {
                    case 1:
                        newRoom = newRoom.enterRoomInfo(newRoom);
                        //newRoom.TtCells1 = new TimetableCells();

                        //newRoom.ttDimensionList[0, 0].HasSubject = true;
                        //newRoom.ttDimensionList[0, 0].TermTTListPosition = 1;
                        SystemList.RoomsList.Add(newRoom);

                        break;
                    case 2:
                        //newRoom.printARoom();
                        break;
                    case 4:
                        //newRoom.collectCellsInfoTest();
                        //newRoom.collectInNormalWay();
                        break;
                    case 5:
                        newRoom.defaultValue(newRoom);
                        break;
                    case 6:
                        newRoom.collectTTTInfo(newRoom);

                        break;

                }


                data.WriteRoomFile();
            }

        }

        public Room enterRoomInfo(Room newRoom)
        {
            //newRoom = newRoom.defaultValue(newRoom);
            newRoom.RoomName = newRoom.enterRoomName(newRoom);
            newRoom.RoomSize = newRoom.enterRoomSize(newRoom);
            
            return newRoom;
        }

        public string enterRoomName(Room newRoom)
        {
            Console.Write("Room Name: ");
            newRoom.RoomName = Console.ReadLine();

            return newRoom.RoomName;
        }

        public int enterRoomSize(Room newRoom)
        {
            Console.Write("Room Size: ");
            newRoom.RoomSize = int.Parse(Console.ReadLine());

            return newRoom.RoomSize;
        }
        /// <summary>
        /// I should write a method which will save room name, then pick up these room name from roomList and make a selection if the room name is equal to another room name which is picked up from the TTTList, then update information for this room.
        /// 
        /// </summary>
        /// <param name="newRoom"></param>
        /// 

        public void collectTTTInfo(Room newRoom)
        {
            
            int TTTPosition = 0, roomListPosition = 0;

            //every time, the system will read "room.xml" which only includes a room name.
            
            SavingAndReading data = new SavingAndReading();
            data.ReadRoomFile("room.xml");
            
            foreach (Room e1 in SystemList.RoomsList)
            {
                //termTimetableList size is fixed, if doesnot initialize the TTTPosition,
                //then the TTTPosition will greater than the size of termTimetable
                TTTPosition = 0;
                foreach (WebpageTermTimetable e2 in SystemList.TermTimetableList)
                {
                    if(e1.RoomName == e2.RoomName)
                    {
                        SystemList.RoomsList[roomListPosition].TtDimensionArray[e2.Day][e2.StartHour - 9].HasSubject = true;
                        SystemList.RoomsList[roomListPosition].TtDimensionArray[e2.Day][e2.StartHour - 9].TermTTListPosition = TTTPosition;
                    }
                    TTTPosition++;
                }
                roomListPosition++;
            }

            data.WriteRoomFile();
        }


        //public void collectCellsInfo(Room newRoom)
        //{
        //    int day = 0;

        //    foreach (Room e_1 in SystemList.RoomsList)
        //    {
        //        int TTTLPosition = 0;

        //        foreach (WebpageTermTimetable e_2 in SystemList.TermTimetableList)
        //        {
        //            if (e_1.RoomName == e_2.RoomName)
        //            {
        //                //cell.BooleanCells[day, e_2.StartHour - 9] = true;
        //                //cell.TTTPosition1 = TTTLPosition;
        //                //cells[day, ]
        //            }

        //            TTTLPosition++;
        //        }
        //        day++;
        //    }
        //}

        //public void collectInNormalWay()
        //{
        //    int position = 0;

        //    foreach (Room e in SystemList.RoomsList)
        //    {
        //        foreach (WebpageTermTimetable e1 in SystemList.TermTimetableList)
        //        {
        //            if(e.roomName == e1.RoomName)
        //            {
        //                //e.moduleName = e1.ModuleFullName;
        //                SystemList.RoomsList[position].moduleName.Add(e1.ModuleFullName);

        //            }
        //        }
        //    }
        //}

        //public void printInNormalWay()
        //{

        //}

        //public void collectCellsInfoTest()
        //{
        //    for (int i = 0; i < SystemList.RoomsList.Count(); i++)
        //    {
        //        Room newRoom = new Room();
        //        newRoom = SystemList.RoomsList[i];

        //        for (int j = 0; j < SystemList.TermTimetableList.Count; j++)
        //        {
        //            WebpageTermTimetable newWTT = new WebpageTermTimetable();
        //            newWTT = SystemList.TermTimetableList[j];

        //            if (newRoom.RoomName == newWTT.RoomName)
        //            {
        //                newRoom.cell.IntCells[newWTT.Day, newWTT.StartHour - 9] = j;
        //                newRoom.cell.TTTPosition1 = j;
        //                //newRoom.ModuleName = newWTT.ModuleFullName;

        //                SystemList.RoomsList[i].cell.IntCells = newRoom.cell.IntCells;
        //                //SystemList.RoomsList[i].ModuleName = newRoom.ModuleName;
        //            }
        //        }

        //    }
        //}

        //public void printARoom()
        //{
        //    Room newRoom = new Room();

        //    Console.Write("Room Name: ");
        //    newRoom.RoomName = Console.ReadLine();
        //    int position;

        //    foreach (Room e in SystemList.RoomsList)
        //    {
        //        if (e.RoomName == newRoom.RoomName)
        //        {
        //            for (int i = 0; i < 5; i++)
        //            {
        //                for (int j = 0; j < 9; j++)
        //                {
        //                    position = e.cell.IntCells[i, j];
        //                    Console.WriteLine(SystemList.TermTimetableList[position].ModuleFullName);
        //                }
        //            }
        //            //Console.WriteLine(e.ModuleName);
        //        }
        //    }
            
        //}

        public void collectCellsInfo(Room newRoom)
        {
            int day = 0, hour = 0, RLPosition = 0, TTTLPosition = 0;
            foreach (Room e1 in SystemList.RoomsList)
            {  
                foreach (WebpageTermTimetable e2 in SystemList.TermTimetableList)
                {
                    if (e1.RoomName == e2.RoomName)
                    {
                        day = e2.Day;
                        hour = e2.StartHour;
                        //e1.cell.IntCells[day, hour] = TTTLPosition;
                        //e1.Cell.IntCells[day, hour] = TTTLPosition;
                        //e1.module.ModuleFullName = e2.ModuleFullName;

                        SystemList.RoomsList[RLPosition] = e1;
                    }
                    TTTLPosition++;
                }
                RLPosition++;
            }
        }

        //public void printARoom(Room newRoom)
        //{
        //    Console.Write("Room Name: ");
        //    newRoom.RoomName = Console.ReadLine();

            
        //}
        /*
        public int RoomSize
        {
            get
            {
                return roomSize;
            }

            set
            {
                roomSize = value;
            }
        }

        //public int RoomID
        //{
        //    get
        //    {
        //        return roomID;
        //    }

        //    set
        //    {
        //        roomID = value;
        //    }
        //}

        public string RoomName
        {
            get
            {
                return roomName;
            }

            set
            {
                roomName = value;
            }
        }

        internal TimetableCells TtCells
        {
            get
            {
                return ttCells;
            }

            set
            {
                ttCells = value;
            }
        }

    */

        //public int[,] Cells
        //{
        //    get
        //    {
        //        return cells;
        //    }

        //    set
        //    {
        //        cells = value;
        //    }
        //}

        //internal TimetableCells Cell
        //{
        //    get
        //    {
        //        return cell;
        //    }

        //    set
        //    {
        //        cell = value;
        //    }
        //}

        //public string ModuleName
        //{
        //    get
        //    {
        //        return ModuleName1;
        //    }

        //    set
        //    {
        //        ModuleName1 = value;
        //    }
        //}

        //public List<string> ModuleName1
        //{
        //    get
        //    {
        //        return moduleName;
        //    }

        //    set
        //    {
        //        moduleName = value;
        //    }
        //}

        //internal TimeCellDay Day
        //{
        //    get
        //    {
        //        return day;
        //    }

        //    set
        //    {
        //        day = value;
        //    }
        //}

        //internal TimetableCells Cell
        //{
        //    get
        //    {
        //        return cell;
        //    }

        //    set
        //    {
        //        cell = value;
        //    }
        //}



        //internal Lecturer LecturerID
        //{
        //    get
        //    {
        //        return lecturerID;
        //    }

        //    set
        //    {
        //        lecturerID = value;
        //    }
        //}

        //internal Module ModuleID
        //{
        //    get
        //    {
        //        return moduleID;
        //    }

        //    set
        //    {
        //        moduleID = value;
        //    }
        //}

        //internal TimeCellHours TimeCell
        //{
        //    get
        //    {
        //        return timeCell;
        //    }

        //    set
        //    {
        //        timeCell = value;
        //    }
        //}


        //public Room enterRoomInfo()
        //{
        //    Room newRoom = new Room();

        //    //newRoom.RoomID = newRoom.enterID(newRoom);
        //    newRoom.RoomName = newRoom.enterName(newRoom);
        //    newRoom.roomSize = newRoom.enterSize(newRoom);

        //    return newRoom;
        //}

        //public int enterID(Room newRoom)
        //{
        //    Console.WriteLine("Please enter the room ID: ");
        //    newRoom.RoomID = int.Parse(Console.ReadLine());
        //    uniqueIDChecking(newRoom);

        //    return newRoom.RoomID;
        //}

        //public string enterName(Room newRoom)
        //{
        //    Console.WriteLine("Please enter the room name: ");
        //    newRoom.RoomName = Console.ReadLine();

        //    return newRoom.RoomName;
        //}

        //public int enterSize(Room newRoom)
        //{
        //    Console.WriteLine("Please enter the room size: ");
        //    newRoom.RoomSize = int.Parse(Console.ReadLine());

        //    return newRoom.RoomSize;

        //}


        //public void uniqueIDChecking(Room newRoom)
        //{
        //    if (SystemList.RoomsList != null)
        //    {
        //        for (int i = 0; i < SystemList.RoomsList.Count(); i++)
        //        {
        //            if (SystemList.RoomsList[i].RoomID == newRoom.RoomID)
        //            {
        //                Console.WriteLine("The room ID you entered: " + newRoom.RoomID + " is existent.");
        //                enterID(newRoom);
        //            }
        //        }
        //    }
        //}

        //public void uniqueNameChecking(Room newRoom)
        //{
        //    if (SystemList.RoomsList != null)
        //    {
        //        for (int i = 0; i < SystemList.RoomsList.Count(); i++)
        //        {
        //            if (SystemList.RoomsList[i].RoomName == newRoom.RoomName)
        //            {
        //                Console.WriteLine("The room name you entered: " + newRoom.RoomName + " is existent.");
        //                enterName(newRoom);
        //            }
        //        }
        //    }
        //}

    }
}
