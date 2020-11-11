using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumosSchool.Model.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        
        private int _age;
        public int Age
        {
            get
            {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }
        public List<Exam> Exams { get; set; }
        public bool Active { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Student()
        {
            Active = true;
        }
    }
}
