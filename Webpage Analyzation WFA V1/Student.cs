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
    public class Student
    {
        private int id;
        private int degree;
        private int grade;
        private int term;
        private string major;
        private bool hasOptionalModule;
        private int optionalModuleTerm;
        private string firstName;
        private string middleName;
        private string lastName;
        //private string department_1;


        public Student()
        {
            Id = 0;
            Degree = 1;
            Grade = 1;
            Term = 1;
            Major = "BSc Computing";
            HasOptionalModule = false;
            OptionalModuleTerm = 0;
            FirstName = "";
            MiddleName = "";
            LastName = "";
            //Department_1 = "";
            //Department_2 = "";
        }


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

        public int Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
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

        public string Major
        {
            get
            {
                return major;
            }

            set
            {
                major = value;
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

        public bool HasOptionalModule
        {
            get
            {
                return hasOptionalModule;
            }

            set
            {
                hasOptionalModule = value;
            }
        }

        public int OptionalModuleTerm
        {
            get
            {
                return optionalModuleTerm;
            }

            set
            {
                optionalModuleTerm = value;
            }
        }

        //public string Department_1
        //{
        //    get
        //    {
        //        return department_1;
        //    }

        //    set
        //    {
        //        department_1 = value;
        //    }
        //}

        //private string department_2;
        public void studentMain()
        {
            Student newStudent = new Student();

            //newStudent.Id = int.Parse(Console.ReadLine());
            //newStudent.Degree = int.Parse(Console.ReadLine());
            //newStudent.Year = int.Parse(Console.ReadLine());
            //newStudent.Term = int.Parse(Console.ReadLine());
            //newStudent.HasOptionalModule = bool.Parse(Console.ReadLine());
            //newStudent.OptionalModuleTerm = int.Parse(Console.ReadLine());
            //newStudent.FirstName = Console.ReadLine();
            //newStudent.MiddleName = Console.ReadLine();
            //newStudent.LastName = Console.ReadLine();
            SystemList.StudentList.Add(newStudent);
        }

        
        public void enterID()
        {

        }

        public void enterLastName()
        {

        }

        public void enterFirstName()
        {

        }

        public void enterMiddleName()
        {

        }

        public void uniqueIDChecking()
        {

        }

        public void warningMessage()
        {

        }

        public bool uniqueIDChecking(int id)
        {
            SavingAndReading data = new SavingAndReading();
            data.ReadStudentFile();

                for (int i = 0; i < SystemList.StudentList.Count(); i++)
                {
                    if (SystemList.StudentList[i].Id == id)
                    {
                        //Console.WriteLine("The ID you entered: " + newStudent.Id + " is existent!");
                        //enterID(newStudent);
                        return false;
                    }

                }

            return true;
        }
    }
}
