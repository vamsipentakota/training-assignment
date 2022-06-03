﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject
{
    public class Enrolment
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;

        public Student _student
        {
            get { return student; }
            set { student = value; }
        }
        public Course _course
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime _dateTime
        {
            get { return enrollmentDate; }
            set { enrollmentDate = value; }
        }

        public Enrolment(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;

        }
    }
}
