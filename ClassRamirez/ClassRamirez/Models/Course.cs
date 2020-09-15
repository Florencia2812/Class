using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassRamirez.Models
{
    public class Course
    {
        [Display(Name ="ID")]
        public int CourseID { get; set; }

        [StringLength(50,MinimumLength =3)]
        public string Title { get; set; }

        [Range(0,5)]
        public int Credits { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}