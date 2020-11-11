using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumosSchool.Model.Model
{
    public class Classroom
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Subject { get; set; }
        public List<Student> Students { get; set; }
    }
}
