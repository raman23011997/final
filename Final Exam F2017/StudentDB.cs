using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam_F2017
{
    class StudentDB
    {
        private const string dir = @"C:\C# 2015\Files\";
        private const string path = @"..\..\students.txt"; //dir + "students.txt";
       
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            StreamReader textIn = null;
            Student student;
            try
            {
                // if the directory doesn't exist, create it
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                // create the object for the input stream for a text file
                 textIn =
                    new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));


               
                // read the data from the file and store it in the list
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split('|');
                    student = new Student();
                    student.Name = columns[0];
                 //   student.Percentage=Convert.ToDouble(columns[2]);
                        
                    students.Add(student);
                }
                return students;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message,"input/output Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally {
                // close the input stream for the text file

                if (textIn != null)
                    textIn.Close();
            }
            return students;

        }

      
    


    }
}
