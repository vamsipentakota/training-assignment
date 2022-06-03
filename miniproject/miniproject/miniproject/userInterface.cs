﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject
{
    class UserInterFace : interfaceuser
    {
        engine engine = new engine();

        string res;
        public void showFirstScreen()
        {
            do
            {


                Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
                Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
                Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:
                        showAdminScreen();
                        break;
                    default:
                        Console.WriteLine("Choose Valid Option");
                        break;
                }
                Console.WriteLine("Do you want to continue Main Screen:Yes or N0");
                res = Console.ReadLine();
            }
            while ((res == "YES") || (res == "yes"));
        }

        public void showStudentScreen()
        {
            do
            {
                Console.WriteLine("Select: \n1.Check your Details(Existing User)\n2.Registration(New User)\n3.Search Available Courses\n4.Enroll to Course in List");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:

                        engine.ParticularStudent();
                        Console.WriteLine("Action Completed you may Exit");
                        break;
                    case 2:

                        this.showStudentRegistrationScreen();
                        Console.WriteLine("Action Completed you may Exit");
                        break;
                    case 3:

                        Console.WriteLine("List of Courses");
                        engine.AllCoursesLists();
                        Console.WriteLine("Action Completed you may Exit");
                        break;
                    case 4:

                        engine.EnrollstudentDetailslists();
                        Console.WriteLine("You have successfully enrolled you may Exit the Screen now");
                        break;
                    default:

                        Console.WriteLine("Enter valid Option");
                        break;
                }
                Console.WriteLine("Do you want to continue Student Screen:Yes or No");
                res = Console.ReadLine();
            } while ((res == "YES") || (res == "yes"));
        }
        public void showAdminScreen()
        {
            do
            {
                Console.WriteLine("Select: \n1.Introduce New Course\n2.Courses Available\n3.Update Course Details\n4.Retrieve Particular Course in List\n5.Deleting Existing Student\n6.Delete Course\n7.Update Student Details\n8.All Registered Students");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:

                        this.introduceNewCourseScreen();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 2:

                        Console.WriteLine("All Available Courses in Institute");
                        showAllCoursesScreen();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 3:

                        engine.updatestudentCourse();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 4:

                        engine.ParticularCourse();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 5:

                        engine.DeleteStudents();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 6:

                        engine.DeletestudentCourse();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 7:

                        engine.UpdateStudent();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 8:

                        showAllStudentsScreen();
                        break;

                    default:
                        Console.WriteLine("Enter valid Option....!");
                        break;
                }
                Console.WriteLine("Do you want to continue Admin Screen:Yes or No");
                res = Console.ReadLine();
            } while ((res == "YES") || (res == "yes"));

        }
        public void showAllStudentsScreen()
        {
            Console.WriteLine("List of All Student Details : ");
            engine.AllStudentDetails();
        }
        public void showStudentRegistrationScreen() 
        {
            Console.WriteLine("You are Entering into Student Registration form :");
            Console.WriteLine("Enter the Student Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Student DOB:");
            string dob = Console.ReadLine();
            engine.studentregister(new Student(id, name, dob));
        }

        public void introduceNewCourseScreen()
        {
            engine.insertingstudentCourse();
        }
        public void showAllCoursesScreen()
        {
            Console.WriteLine("List of all courses : ");
            engine.AllCoursesLists();
        }
    }
}
