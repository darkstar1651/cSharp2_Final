﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Weidner_School_Final_Project.Models
{
    public partial class Student
    {
        public Student()
        {
            AssignmentsStudents = new HashSet<AssignmentsStudent>();
            CoursesStudents = new HashSet<CoursesStudent>();
        }

        public int StudentId { get; set; }
        public string StudentFirstname { get; set; }
        public string StudentLastname { get; set; }
        public string StudentPassword { get; set; }
        public string StudentPhone { get; set; }
        public string StudentEmail { get; set; }
        public string StudentAddress { get; set; }

        public virtual ICollection<AssignmentsStudent> AssignmentsStudents { get; set; }
        public virtual ICollection<CoursesStudent> CoursesStudents { get; set; }
    }
}