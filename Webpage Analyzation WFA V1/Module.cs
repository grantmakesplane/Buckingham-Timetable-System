using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    public class Module
    {
        private int moduleID;
        private int lecturerID;
        private string moduleFullName;
        private string moduleShortName;
        private bool practicalSession;
        private int practicalAssitantID;
        private int lectureHours;
        private int practicalHours;
        private int year;
        private int term;
        private int degree;

        public int ModuleID
        {
            get
            {
                return moduleID;
            }

            set
            {
                moduleID = value;
            }
        }

        public string ModuleFullName
        {
            get
            {
                return moduleFullName;
            }

            set
            {
                moduleFullName = value;
            }
        }

        public string ModuleShortName
        {
            get
            {
                return moduleShortName;
            }

            set
            {
                moduleShortName = value;
            }
        }

        public bool PracticalSession
        {
            get
            {
                return practicalSession;
            }

            set
            {
                practicalSession = value;
            }
        }

        public int LectureHours
        {
            get
            {
                return lectureHours;
            }

            set
            {
                lectureHours = value;
            }
        }

        public int PracticalHours
        {
            get
            {
                return practicalHours;
            }

            set
            {
                practicalHours = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public int Term
        {
            get
            {
                return term;
            }

            set
            {
                term = value;
            }
        }

        public int Degree
        {
            get
            {
                return degree;
            }

            set
            {
                degree = value;
            }
        }

        public int LecturerID
        {
            get
            {
                return lecturerID;
            }

            set
            {
                lecturerID = value;
            }
        }

        public int PracticalAssitantID
        {
            get
            {
                return practicalAssitantID;
            }

            set
            {
                practicalAssitantID = value;
            }
        }

        public Module()
        {
            ModuleID = 0;
            LecturerID = 1000001;
            ModuleFullName = "";
            ModuleShortName = "";
            PracticalSession = false;   // if the module has a practical session or not
            PracticalAssitantID = 0;
            PracticalHours = 0;
            LectureHours = 0;
            Year = 1;
            Term = 1;
            Degree = 1;
        }

        

        //internal Degree Degree
        //{
        //    get
        //    {
        //        return degree;
        //    }

        //    set
        //    {
        //        degree = value;
        //    }
        //}

        public void moduleChoices()
        {
            int choice;
            Module newModule = new Module();

            Console.WriteLine("\n**********************Module class**********************");
            Console.WriteLine("\nWhich function you want to choose?");
            Console.WriteLine("\n1. Add a new module \n2. Delete a module \n3. Modify a module \n4. Print Module Info");
            Console.Write("I want to choose: ");
            choice = int.Parse(Console.ReadLine());

            SavingAndReading data = new SavingAndReading();

            switch (choice)
            {
                case 1:
                    newModule = newModule.enterModuleInfo(newModule);
                    SystemList.ModuleList.Add(newModule);

                    data.WriteModuleFile();
                    break;
                    
                case 2:
                    newModule.removeModule(newModule);
                    break;
                    
                case 3:
                    newModule.modifyModuleDetails();
                    break;

                case 4:
                    //PrintInfo newPrintInfo = new PrintInfo();
                    //newPrintInfo.printModulesInfo();
                    break;

                default:
                    
                        Console.WriteLine("The choice you entered is not correct. Please try again.");
                        newModule.moduleChoices();
                        break;
                    
            }
            
        }

        public Module enterModuleInfo(Module newModule)
        {
            //Module newModule = new Module();

            //newModule.ModuleID = newModule.enterID(newModule);
            newModule.ModuleFullName = newModule.enterFullName(newModule);
            newModule.moduleShortName = newModule.enterShortName(newModule);
            //newModule.LectureHours = newModule.enterLectureHours(newModule);
            //newModule.PracticalSession = newModule.enterPracticalSession(newModule);
            newModule.Degree = newModule.enterDegree(newModule);
            newModule.Year = newModule.enterYear(newModule);
            newModule.Term = newModule.enterTerm(newModule);

            //newModule.practicalHours = newModule.enterPracticalHours(newModule);
            return newModule;
        }

        public int enterID(Module newModule)
        {
            //int position;

            Console.WriteLine("Please enter the module ID: ");
            newModule.ModuleID = int.Parse(Console.ReadLine());

            
            newModule.uniqueIDChecking(newModule);



            return newModule.ModuleID;
        }

        public string enterFullName(Module newModule)
        {
            Console.WriteLine("Please enter the module full name: ");
            newModule.ModuleFullName = Console.ReadLine();
            

            return newModule.ModuleFullName;
        }

        public string enterShortName(Module newModule)
        {
            Console.WriteLine("Please enter the module short name: ");
            newModule.ModuleShortName = Console.ReadLine();

            return newModule.ModuleShortName;
        }

        public int enterLectureHours(Module newModule)
        {
            Console.WriteLine("How long the lecture will take?(hours)");
            Console.Write("The lecture will take: ");
            newModule.LectureHours = int.Parse(Console.ReadLine());

            if(newModule.LectureHours > 3)
            {
                Console.WriteLine("The lecture will take over 3 hours. Please try enter again.");
                newModule.enterLectureHours(newModule);
            }

            return newModule.LectureHours;
        }

        public bool enterPracticalSession(Module newModule)
        {
            string ans;

            Console.WriteLine("This module is include practical session or not?(Y/N)");
            Console.WriteLine("The answer is: ");
            ans = Console.ReadLine();

            if (ans.ToUpper() == "Y")
            {
                newModule.PracticalSession = true;
                newModule.enterPracticalHours(newModule);

            }else if (ans.ToUpper() == "N")
            {
                newModule.PracticalSession = false;

            }else
            {
                Console.WriteLine("The answer you enter is not correct. Please try again.");
                newModule.enterPracticalSession(newModule);

            }

            //newModule.PracticalSession = 

            return newModule.PracticalSession;
        }

        public int enterPracticalHours(Module newModule)
        {
            Console.WriteLine("\nHow long the practical session will take?(hours)");
            Console.Write("It will take: ");
            newModule.PracticalHours = int.Parse(Console.ReadLine());

            if (newModule.PracticalHours > 3)
            {
                Console.WriteLine("The lecture will take over 3 hours. Please try enter again.");
                newModule.enterPracticalHours(newModule);
            }

            return newModule.PracticalHours;
        }

        public void uniqueIDChecking(Module newModule)
        {
            //int position = -1;

            if (SystemList.ModuleList != null)
            {
                for (int position = 0; position < SystemList.ModuleList.Count(); position++)
                {
                    if (SystemList.ModuleList[position].ModuleID == newModule.ModuleID)
                    {
                        Console.WriteLine("The ID you entered: " + newModule.ModuleID + " is existent!");
                        newModule.enterID(newModule);
                        break;// if find the ID from the moudule list, then return the position where is the ID in the module list.
                    }
                }
            }
            //return position;
        }

        public int enterDegree(Module newModule)
        {
            Console.WriteLine("\nPlease enter which level students will take the module: ");
            Console.Write("Level: ");
            newModule.Degree = int.Parse(Console.ReadLine());

            return newModule.Degree;
        }

        public int enterYear(Module newModule)
        {
            Console.WriteLine("\nPlease enter the which grade of students will take the module: ");
            Console.Write("Grade: ");
            newModule.Year = int.Parse(Console.ReadLine());

            return newModule.Year;
        }

        public int enterTerm(Module newModule)
        {
            Console.WriteLine("Please enter which term the students will take " + newModule.ModuleFullName + " :");
            Console.Write("Term: ");
            newModule.Term = int.Parse(Console.ReadLine());

            return newModule.Term;
        }


        public void modifyModuleDetails()
        {
            int position = 0;
            bool IDFound = false;
            Module newModule = new Module();

            Console.WriteLine("\nWhich module you want to change?");
            Console.WriteLine("Please enter the ID: ");
            newModule.ModuleID = int.Parse(Console.ReadLine());

            //position = newModule.uniqueIDChecking(newModule);

            for(position = 0; position < SystemList.ModuleList.Count(); position++)
            {
                if (SystemList.ModuleList[position].ModuleID == newModule.ModuleID)
                {
                    IDFound = true;
                    break;
                }
            }

            if (IDFound == false)
            {
                Console.WriteLine("The ID you entered: " + newModule.ModuleID + " is not found!\n");
                newModule.modifyModuleDetails();
            }else
            {
                newModule.printInfo(newModule);
                newModule.modifySpecificModule(position, newModule);
            }

            //if (Console.WriteLine() == )

            //return newModule;
        }


        // the reason why I create another method instead of writing functions into modifyModuleDetails is if the ans is not correct, then I can ask user to enter the ans again.
        public void modifySpecificModule(int position, Module newModule)
        {
            int ans;

            Console.WriteLine("You want to change all the information or a specific one?");
            Console.WriteLine("1. All of them \n2. ID \n3. Name \n4. Practical Session");
            Console.WriteLine("I want to change: ");

            ans = int.Parse(Console.ReadLine());

            switch (ans)
            {
                case 1:
                    SystemList.ModuleList[position] = newModule.enterModuleInfo(newModule);
                    break;

                case 2:
                    SystemList.ModuleList[position].ModuleID = newModule.enterID(newModule);
                    break;

                case 3:
                    SystemList.ModuleList[position].ModuleFullName = newModule.enterFullName(newModule);
                    break;

                case 4:
                    SystemList.ModuleList[position].PracticalSession = newModule.enterPracticalSession(newModule);
                    break;

                default:
                    Console.WriteLine("The number you entered is not correct. Please try again.");
                    newModule.modifySpecificModule(position, newModule);
                    break;
            }
        }


        /// <summary>
        /// the method is to remove a module with a specify ID
        /// </summary>
        /// <param name="newModule"></param>
        public void removeModule(Module newModule)
        {
            int position;
            bool IDFound = false;

            Console.WriteLine("Please enter the ID you want to remove: ");
            newModule.ModuleID = int.Parse(Console.ReadLine());

            //position = newModule.uniqueIDChecking(newModule);

            for (position = 0; position < SystemList.ModuleList.Count(); position++)
            {
                if (SystemList.ModuleList[position].ModuleID == newModule.ModuleID)
                {
                    IDFound = true;
                    break;
                }
            }
            if (IDFound == false)
            {
                Console.WriteLine("The ID: " + newModule.ModuleID + " you entered is not found. Please try again.");
                removeModule(newModule);
            }else
            {
                SystemList.ModuleList.RemoveAt(position);
                newModule.moduleChoices();
            }
            //SystemList.ModuleList.FindIndex(Predicate<Module> ;
        }

        //public void IDFound(Module newModule)
        //{
        //    int position = 0;

        //    for (position = 0; position < SystemList.ModuleList.Count(); position++)
        //    {
        //        if (SystemList.ModuleList[position].ModuleID == newModule.ModuleID)
        //            //IDFound = true;
        //        break;
        //    }

        //    return position;
        //}

        public void printInfo(Module newModule)
        {
            Console.WriteLine("The module ID: " + newModule.ModuleID);
            Console.WriteLine("The module name: " + newModule.ModuleFullName);
            Console.WriteLine("The module has a practical session: " + newModule.PracticalSession);
        }

    }
}
