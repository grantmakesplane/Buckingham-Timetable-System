using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    public class Lecturer
    {
        

        private int id;
        private string firstName;
        private string middleName;
        private string lastName;
        //private string userAns;

        public Lecturer()
        {
            Id = 0;
            FirstName = "";
            MiddleName = "";
            LastName = "";
            //UserAns = "";
        }

        //public Lecturer newLecturer = new Lecturer();

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        //public string UserAns
        //{
        //    get
        //    {
        //        return userAns;
        //    }

        //    set
        //    {
        //        userAns = value;
        //    }
        //}

        public Lecturer enterLectureInfo()
        {
            Lecturer newLecturer = new Lecturer();
            //Lecturer();
            newLecturer.FirstName = enterFirstName(newLecturer);
            //newLecturer.MiddleName = enterSecondName(newLecturer);
            newLecturer.LastName = enterLastName(newLecturer);
            newLecturer.Id = enterID(newLecturer);

            return newLecturer;
        }

        public string enterFirstName(Lecturer newLecturer)
        {
            Console.WriteLine("Please enter a lecturer's first name: ");
            newLecturer.FirstName = Console.ReadLine();

            return newLecturer.FirstName;
        }

        //public string enterSecondName(Lecturer newLecturer)
        //{
        //    Console.WriteLine("Does the lecturer has a middle name? (y/n)");
        //    UserAns = Console.ReadLine();
        //    if (UserAns.ToLower() == "y")
        //    {
        //        Console.WriteLine("Please enter the lecture's middle name: ");
        //        newLecturer.MiddleName = Console.ReadLine();

        //    }
        //    else if (UserAns.ToLower() == "n")
        //    {
        //        newLecturer.MiddleName = "";

        //    }
        //    else
        //    {
        //        warningMessage();
        //        enterSecondName(newLecturer);
        //    }

        //    return newLecturer.MiddleName;
        //}

        public string enterLastName(Lecturer newLecturer)
        {
            Console.WriteLine("Please enter the lecturer's last name: ");
            newLecturer.LastName = Console.ReadLine();

            return newLecturer.LastName;
        }

        public int enterID(Lecturer newLecturer)
        {
            Console.WriteLine("Please enter the lecturer ID: ");
            newLecturer.Id = int.Parse(Console.ReadLine());
            //uniqueIDChecking(newLecturer);
            return newLecturer.Id;
        }

        public void warningMessage()
        {
            Console.WriteLine("Please check your answer!");
        }

        public bool uniqueIDChecking(int id)
        {
            //foreach ( element in SystemList.LecturerList)

                for (int i = 0; i < SystemList.LecturerList.Count(); i++)
                {
                    if (SystemList.LecturerList[i].Id == id)
                    {
                        return false;
                    }

                }

            return true;
        }
    }
}
