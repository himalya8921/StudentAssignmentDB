using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentEntities.Entities
{
    public partial class School
    {
        public long SchoolId { get; set; }
        public long Guiid { get; set; }
        public string SchoolName { get; set; }
        public string City { get; set; }
        public bool SchoolType { get; set; }
        public string SchoolLogo { get; set; }
    }
}
