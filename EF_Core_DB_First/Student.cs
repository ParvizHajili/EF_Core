using System;
using System.Collections.Generic;

namespace EF_Core_DB_First
{
    public partial class Student
    {
        public Student()
        {
            StudentNumbers = new HashSet<StudentNumber>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public byte Age { get; set; }
        public string Email { get; set; } = null!;
        public int? Deleted { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<StudentNumber> StudentNumbers { get; set; }
    }
}
