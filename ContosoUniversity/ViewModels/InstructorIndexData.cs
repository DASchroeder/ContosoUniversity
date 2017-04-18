using System.Collections.Generic;
using ContosoUniversity.Models;
using ContosoUniversity.ViewModels;

namespace ContosoUniversity.ViewModels
{
    public class InstructorIndexData
    {

        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}