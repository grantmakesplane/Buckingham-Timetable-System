using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Webpage_Analyzation_WFA_V1
{
    class SavingAndReading
    {
        string lecturerFilename;
        string studentFilename;
        string roomFilename;
        string moduleFilename;
        string termTimetableFilename;
        string sgFilename;
        string templateFilename;

        public string LecturerFilename
        {
            get
            {
                return lecturerFilename;
            }

            set
            {
                lecturerFilename = value;
            }
        }

        public string StudentFilename
        {
            get
            {
                return studentFilename;
            }

            set
            {
                studentFilename = value;
            }
        }

        public string RoomFilename
        {
            get
            {
                return roomFilename;
            }

            set
            {
                roomFilename = value;
            }
        }

        public string ModuleFilename
        {
            get
            {
                return moduleFilename;
            }

            set
            {
                moduleFilename = value;
            }
        }

        public string TermTimetableFilename
        {
            get
            {
                return termTimetableFilename;
            }

            set
            {
                termTimetableFilename = value;
            }
        }

        public string SgFilename
        {
            get
            {
                return sgFilename;
            }

            set
            {
                sgFilename = value;
            }
        }

        public string TemplateFilename
        {
            get
            {
                return templateFilename;
            }

            set
            {
                templateFilename = value;
            }
        }

        //string path;

        public SavingAndReading()
        {
            createFolder();
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Timetable System");
            LecturerFilename = path + "\\lecturer.xml";
            StudentFilename = path + "\\student.xml";
            RoomFilename = path + "\\room.xml";
            ModuleFilename = path + "\\module.xml";
            TermTimetableFilename = path + "\\termTimetable.xml";
            SgFilename = path + "\\sessionGroup.xml";
            TemplateFilename = path + "\\template.xml";
            //LecturerFilename = "G:\\individual project\\DataSavings\\lecturer.xml";
            //StudentFilename = "G:\\individual project\\DataSavings\\student.xml";
            //RoomFilename = "G:\\individual project\\DataSavings\\room.xml";
            //ModuleFilename = "G:\\individual project\\DataSavings\\module.xml";
            //TermTimetableFilename = "G:\\individual project\\DataSavings\\termTimetable.xml";
            //path = "H:";
        }


        public void WriteSystemList()
        {
            WriteLecturerFile();
            WriteStudentFile();
            WriteRoomFile();
            WriteModuleFile();
            WriteTermTimetable();
            WriteSgFile();
            WriteTemplate();
        }


        public void ReadSystemList()
        {
            ReadLecturerFile();
            ReadStudentFile();
            ReadRoomFile(RoomFilename);
            ReadModuleFile(ModuleFilename);
            ReadTermTimetableFile();
            ReadSgFile();
            ReadTemplateFile();
        }


        /// <summary>
        /// Write File Methods
        /// </summary>
        public void WriteLecturerFile()
        {
            XmlSerializer serializerLecturer = new XmlSerializer(typeof(List<Lecturer>));
            TextWriter writerLecturer = new StreamWriter(LecturerFilename);
            serializerLecturer.Serialize(writerLecturer, SystemList.LecturerList);
            writerLecturer.Close();
        }


        public void WriteStudentFile()
        {
            XmlSerializer serializerStudent = new XmlSerializer(typeof(List<Student>));
            TextWriter writerStudent = new StreamWriter(StudentFilename);
            serializerStudent.Serialize(writerStudent, SystemList.StudentList);
            writerStudent.Close();
        }

        public void WriteRoomFile()
        {
            XmlSerializer serializerRoom = new XmlSerializer(typeof(List<Room>));
            TextWriter writerRoom = new StreamWriter(RoomFilename);
            serializerRoom.Serialize(writerRoom, SystemList.RoomsList);
            writerRoom.Close();
        }

        public void WriteModuleFile()
        {
            XmlSerializer serializerModule = new XmlSerializer(typeof(List<Module>));
            TextWriter writerModule = new StreamWriter(ModuleFilename);
            serializerModule.Serialize(writerModule, SystemList.ModuleList);
            writerModule.Close();
        }

        public void WriteTermTimetable()
        {
            XmlSerializer serializerTermTimetable = new XmlSerializer(typeof(List<WebpageTermTimetable>));
            TextWriter writerTermTimetable = new StreamWriter(TermTimetableFilename);
            serializerTermTimetable.Serialize(writerTermTimetable, SystemList.TermTimetableList);
            writerTermTimetable.Close();
        }

        public void WriteSgFile()
        {
            File.Delete(sgFilename);

            XmlSerializer serializerSg = new XmlSerializer(typeof(List<SessionGroups>));
            TextWriter writerSg = new StreamWriter(SgFilename);
            serializerSg.Serialize(writerSg, SystemList.SessionGroupList);
            writerSg.Close();
        }

        public void WriteTemplate()
        {
            File.Delete(templateFilename);

            XmlSerializer serializerTemplate = new XmlSerializer(typeof(List<TTTemplateList>));
            TextWriter writerTemplate = new StreamWriter(TemplateFilename);
            serializerTemplate.Serialize(writerTemplate, SystemList.TemplateList);
            writerTemplate.Close();
        }
        
        /// <summary>
        /// Read File Methods
        /// </summary>
        public void ReadLecturerFile()
        {
            XmlSerializer serializerLecturer = new XmlSerializer(typeof(List<Lecturer>));

            try
            {
                FileStream fsLecturer = new FileStream(LecturerFilename, FileMode.Open);
                SystemList.LecturerList = (List<Lecturer>)serializerLecturer.Deserialize(fsLecturer);
                fsLecturer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadStudentFile()
        {
            XmlSerializer serializerStudent = new XmlSerializer(typeof(List<Student>));

            try
            {
                FileStream fsStudent = new FileStream(StudentFilename, FileMode.Open);
                SystemList.StudentList = (List<Student>)serializerStudent.Deserialize(fsStudent);
                fsStudent.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadRoomFile(string roomFilename)
        {
            XmlSerializer serializerRoom = new XmlSerializer(typeof(List<Room>));

            try
            {
                FileStream fsRoom = new FileStream(roomFilename, FileMode.Open);
                SystemList.RoomsList = (List<Room>)serializerRoom.Deserialize(fsRoom);
                fsRoom.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadModuleFile(string moduleFilename)
        {
            XmlSerializer serializerModule = new XmlSerializer(typeof(List<Module>));

            try
            {
                FileStream fsModule = new FileStream(moduleFilename, FileMode.Open);
                SystemList.ModuleList = (List<Module>)serializerModule.Deserialize(fsModule);
                fsModule.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadTermTimetableFile()
        {
            XmlSerializer serializerTermTimetable = new XmlSerializer(typeof(List<WebpageTermTimetable>));

            try
            {
                FileStream fsTermTimetable = new FileStream(TermTimetableFilename, FileMode.Open);
                SystemList.TermTimetableList = (List<WebpageTermTimetable>)serializerTermTimetable.Deserialize(fsTermTimetable);
                fsTermTimetable.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadSgFile()
        {
            XmlSerializer serializerSg = new XmlSerializer(typeof(List<SessionGroups>));

            try
            {
                FileStream fsSg = new FileStream(SgFilename, FileMode.Open);
                SystemList.SessionGroupList = (List<SessionGroups>)serializerSg.Deserialize(fsSg);
                fsSg.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadTemplateFile()
        {
            XmlSerializer serializerTemplate = new XmlSerializer(typeof(List<TTTemplateList>));

            try
            {
                FileStream fsTemplate = new FileStream(TemplateFilename, FileMode.Open);
                SystemList.TemplateList = (List<TTTemplateList>)serializerTemplate.Deserialize(fsTemplate);
                fsTemplate.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void createFolder()
        {
            string folder = "Timetable System";

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

        public static void ReplaceFile(string FileToMoveAndDelete, string FileToReplace, string BackupOfFileToReplace)
        {
            File.Replace(FileToMoveAndDelete, FileToReplace, BackupOfFileToReplace, false);
        }
    }
}
