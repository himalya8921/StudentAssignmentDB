using Microsoft.Extensions.Logging;
using X.PagedList;
using StudentAssignmentDb.Models;
using StudentBO.Interface;
using StudentEntities.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentEntities.CustomEntities;

namespace StudentAssignmentDb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentBusinessAccess _studentComponent;
        static int orderByName = 1;

        public HomeController(IStudentBusinessAccess obj)
        {
            _studentComponent = obj;
        }

        public ActionResult Privacy()
        {
            return View();
        }
        public ActionResult AddNewStudent()
        {

            List<Teacher> teacherList = _studentComponent.GetTeachers();
            List<College> collegeList = _studentComponent.GetColleges();

            List<string> collegeNames = new List<string>();
            List<string> teacherNames = new List<string>();

            foreach (var item in collegeList)
            {
                collegeNames.Add(item.CollegeName);
            }

            foreach (var item in teacherList)
            {
                teacherNames.Add(item.TeacherName);
            }

            ViewBag.CollegeNames = collegeNames;
            ViewBag.TeacherNames = teacherNames;


            return View();
        }

        public ActionResult DisplayStudentsList()
        {
            return View(_studentComponent.GetStudents());
        }
        public ActionResult Index(string Sorting_Order, string Search_Data, string Filter_Value, int? Page_No)
        {
            ViewBag.CurrentSortOrder = Sorting_Order;
            ViewBag.Student_Id = String.IsNullOrEmpty(Sorting_Order) ? "Student_Id" : "";
            ViewBag.Student_Name = String.IsNullOrEmpty(Sorting_Order) ? "Student_Name" : "";
            ViewBag.FilterValue = Search_Data;

            var students = from stu in _studentComponent.GetCustomStudentData() select stu;

            if (!String.IsNullOrEmpty(Search_Data))
            {
                students = students.Where(stu => stu.StudentName.ToUpper().Contains(Search_Data.ToUpper())
                    || stu.LastName.ToUpper().Contains(Search_Data.ToUpper()));
            }
            switch (Sorting_Order)
            {
                case "Student_Name":
                    students = students.OrderByDescending(stu => stu.StudentName);
                    break;
                case "Student_Id":
                    students = students.OrderByDescending(stu => stu.StudentId);
                    break;

                default:
                    students = students.OrderBy(stu => stu.StudentId);
                    break;
            }

            return View(students.ToList());
        }


        public IActionResult Candidates(int id)
        {
            if (id == 0)
                id = 1;
            ViewBag.PageNo = id;
            ViewBag.TotalPages = _studentComponent.pages();
            return View(_studentComponent.Pagination(id));
        }


        public ActionResult DisplayIndividualStudent(long id)
        {
            StudentModel studentObj = _studentComponent.GetCustomStudentData().FirstOrDefault(x => x.StudentId == id);
            return View(studentObj);

        }

        [HttpPost]
        public ActionResult AddNewStudent(Student student)
        {
            _studentComponent.InsertUpdateStudent(student);
            return RedirectToAction("Index");
        }


        public ActionResult UpdateStudent(long id)
        {

            List<Teacher> teacherList = _studentComponent.GetTeachers();
            List<College> collegeList = _studentComponent.GetColleges();

            List<string> collegeNames = new List<string>();
            List<string> teacherNames = new List<string>();

            foreach (var item in collegeList)
            {
                collegeNames.Add(item.CollegeName);
            }

            foreach (var item in teacherList)
            {
                teacherNames.Add(item.TeacherName);
            }

            ViewBag.CollegeNames = collegeNames;
            ViewBag.TeacherNames = teacherNames;



            Student studentObj = _studentComponent.GetStudents().FirstOrDefault(x => x.StudentId == id);
            return View(studentObj);
        }

        [HttpPost]
        public ActionResult UpdateStudent(Student studentObj)
        {
        
                _studentComponent.InsertUpdateStudent(studentObj);
                return RedirectToAction("Index");

        }


        public ActionResult DeleteStudent(long id)
        {
            _studentComponent.DeleteStudent(id);
            return RedirectToAction("Index");

        }

    }
}
