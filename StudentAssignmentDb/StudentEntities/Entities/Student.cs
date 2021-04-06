using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentEntities.Entities
{
    public partial class Student
    {
        public long StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentCity { get; set; }
        public string StudentState { get; set; }
        public string FathersName { get; set; }
        public string LastName { get; set; }
        public long TeacherId { get; set; }
        public long CollegeId { get; set; }

        public virtual College College { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
