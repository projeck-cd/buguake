using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        
            public int ID { get; set; }
            
            public string Name { get; set; }
            
            public DateTime EnrollmentDate { get; set; }

            public virtual ICollection<Enrollment> Enrollments { get; set; }
        
    }
}