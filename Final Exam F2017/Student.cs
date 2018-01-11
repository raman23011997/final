using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name :Ramanjeet Singh
* Date:09/01/2018
* 
* Purpose:This application calcualte the grades of the studnt based on their final Percentage
* 
* */
namespace Final_Exam_F2017
{
    public class Student
    {
        private String name;
        private Double percentage;

        public Student()
        {
        }

        public Student(String name , Double percentage)
        {
            Name = name;
            Percentage = percentage;
        }

        public string Name { get; set; }
        public double Percentage { get; set; }

        
        public string GetDisplayText()

        {
            // string cc = Code; //invoking the get method
            return Name;
        }
    }
}
