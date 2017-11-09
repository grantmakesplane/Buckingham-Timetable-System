using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataShare_V1
{
    class PrintInfo
    {
        private int choice;

        public PrintInfo()
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

        public void printMain()
        {
            Console.WriteLine("Which objects you want to print?");
            Console.WriteLine("1. Lecturer  2. Room     3. Student\n");

            PrintInfo newChoice = new PrintInfo();
            newChoice.Choice = int.Parse(Console.ReadLine());

            switch(newChoice.Choice)
            {
                case 1:
                    printLecturer();
                    break;

                case 2:
                    printTermTimtable();
                    break;
                //case 2:
                default:
                    printLecturer();
                    break;    
            }
        }


        public void printLecturer()
        {

            Console.WriteLine("You want to print them all or just print an specific lecturer?");
            Console.WriteLine("1. All of them   2.  A Specific lecturer\n");

            PrintInfo newChoice = new PrintInfo();
            newChoice.Choice = int.Parse(Console.ReadLine());

            switch (newChoice.Choice)
            {
                case 1:
                    printAllLecturers();
                    break;
                case 2:
                    printSpecificPerson();
                    break;
                default:
                    printSpecificPerson();
                    break;
            }
        }

        public void printAllLecturers()
        {
            Lecturer newLecturer = new Lecturer(); //i dont need to type SystemList again and again.
            
            for (int position = 0; position < SystemList.LecturerList.Count(); position++)
            {
                newLecturer = SystemList.LecturerList[position];

                lecturerDetails(newLecturer, position);
            }
        }

        public void printSpecificPerson()
        {
            Lecturer newLecturer = new Lecturer();
            int lecturerID;
            int position;
            

            Console.WriteLine("Please enter the ID you want to print:");
            lecturerID = int.Parse(Console.ReadLine());

            position = IDChecking(lecturerID);

            if (position != -1)
            {
                newLecturer = SystemList.LecturerList[position];

                lecturerDetails(newLecturer, position);
            }

        }

        public void middleNameChecking(int position, Lecturer newLecturer)
        {
            if (newLecturer.MiddleName != "")
            {
                Console.WriteLine("The middle name is: " + newLecturer.MiddleName);
            }
        }

        public int IDChecking(int lecturerID)
        {
            int position = -1;
            bool foundID = false;

            for (int i = 0; i < SystemList.LecturerList.Count(); i++)
            {
                if (lecturerID == SystemList.LecturerList[i].Id)
                {
                    position = i;
                    foundID = true;

                    //return position;
                }
            }

            if (foundID == false)
            {
                Console.WriteLine("The ID you entered is not found. Please enter it again.\n");
                //return position;
            }
            return position;
        }

        public void lecturerDetails(Lecturer newLecturer, int position)
        {
            Console.WriteLine("The " + position + " ID is: " + newLecturer.Id);
            Console.WriteLine("The first name is: " + newLecturer.FirstName);
            middleNameChecking(position, newLecturer);
            Console.WriteLine("The last name is: " + newLecturer.LastName);
            Console.WriteLine();
        }


        public void printModulesInfo()
        {
            Console.WriteLine("\n**********************PrintInfo class(printModuleInfo())**********************");
            foreach (Module element in SystemList.ModuleList)
            {
                Console.WriteLine("The Module ID: " + element.ModuleID);
                Console.WriteLine("The Full Module Name: " + element.ModuleFullName);
                Console.WriteLine("The Short Module Name: " + element.ModuleShortName);
            }
        }

        public void printTermTimtable()
        {
            foreach (WebpageTermTimetable element in SystemList.TermTimetableList)
            {
                Console.WriteLine("\nDay: " + element.Day);
                Console.WriteLine("The Module Full Name: " + element.ModuleFullName);
                Console.WriteLine("The Module Short Name: " + element.ModuleShortName);

                Console.WriteLine("The Module Start From: " + element.StartHour);
                Console.WriteLine("The Module End At: " + element.StartMin);

                Console.WriteLine("The Room Name: " + element.RoomName);
                Console.WriteLine("The Room Size: " + element.RoomSize);
                
            }

        }
    }
}
