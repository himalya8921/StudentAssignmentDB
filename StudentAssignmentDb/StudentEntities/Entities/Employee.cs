using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentEntities.Entities
{
    public partial class Employee
    {
        public long Empid { get; set; }
        public string EmpName { get; set; }
        public string Salary { get; set; }
        public string City { get; set; }
        public bool? IsFte { get; set; }
        public bool IsActive { get; set; }
    }
}
