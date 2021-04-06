using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentEntities.Entities
{
    public partial class Teacher
    {
        public Teacher()
        {
            Student = new HashSet<Student>();
        }

        public long TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int Salary { get; set; }
        public long CollegeId { get; set; }

        public virtual College College { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
