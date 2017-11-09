using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataShare_V1
{
    class UserChoice
    {
        private int choice;

        public UserChoice()
        {
            choice = 1;
        }

        public int Choice
        {
            get
            {
                return choice;
            }

            set
            {
                choice = value;
            }
        }

        public void choiceList()
        {
            Console.WriteLine("\n**********************UserChoice class**********************");
            Console.WriteLine("Which function you want to use?");
            Console.WriteLine("1. Lecturer \n2. Room \n3. Module \n4. Analyzation \n5. Print");
            Console.Write("I want to use number: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // create a SavingAndReading object to save data whatever users entered.
            SavingAndReading data = new SavingAndReading();

            switch (choice)
            {
                case 1:
                    Lecturer newLecture = new Lecturer();
                    newLecture = newLecture.enterLectureInfo();
                    SystemList.LecturerList.Add(newLecture);

                    data.WriteSystemList();

                    break;

                case 2:
                    Room newRoom = new Room();
                    newRoom.roomMain();
                    //SystemList.RoomsList.Add(newRoom);

                    //data.WriteSystemList();

                    break;

                case 3:
                    Module newModule = new Module();
                    newModule.moduleChoices();

                    break;

                case 4:
                    WebpageAnalyzation newWeb = new WebpageAnalyzation();
                    newWeb.WebpageAnalyzationMain();

                    break;

                case 5:
                    PrintInfo newPrint = new PrintInfo();
                    newPrint.printMain();
                    break;

                case 6:
                    ProduceTT ptt = new ProduceTT();
                    ptt.produceRoomTimetable();
                    break;

                case 7:
                    Student newStudent = new Student();
                    newStudent.studentMain();
                    break;

                default:
                    choiceList();
                    break;
            }

            //choiceList();
            //return choice;
        }

        //public void choiceChecking()
        //{
        //    if ()
        //}
    }
}
