﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassRamirez.Models
{
    public enum Grades
    {
        A,B,C,D,F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        [Display(Name ="Nota")]
        [DisplayFormat(NullDisplayText ="Sin nota")]
        public Grades? Grade { get; set; }

        public virtual Course  Course{ get; set; }

        public virtual Student Student { get; set; }

    }
}