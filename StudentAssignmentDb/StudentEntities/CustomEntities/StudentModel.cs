using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentEntities.CustomEntities
{
    public class StudentModel
    {
        [Key]
        public long StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentCity { get; set; }
        public string StudentState { get; set; }
        public string FathersName { get; set; }
        public string LastName { get; set; }
        public string TeacherName { get; set; }
        public string CollegeName { get; set; }

    }
}
