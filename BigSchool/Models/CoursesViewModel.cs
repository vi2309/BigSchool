using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BigSchool.Models
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }

    }
}