using System;
using System.Collections.Generic;

namespace EF_Core_DB_First
{
    public partial class StudentNumber
    {
        public int Id { get; set; }
        public string Number { get; set; } = null!;
        public int? StudentId { get; set; }
        public int? Deleted { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Student? Student { get; set; }
    }
}
