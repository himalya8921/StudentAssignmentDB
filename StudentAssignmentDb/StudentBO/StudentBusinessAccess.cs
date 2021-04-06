using StudentBO.Interface;
using StudentDO.Interface;
using StudentEntities.CustomEntities;
using StudentEntities.Entities;
using System;
using System.Collections.Generic;

namespace StudentBO
{
    public class StudentBusinessAccess: IStudentBusinessAccess
    {


        private readonly IStudentDataAccess _studentData;

        public StudentBusinessAccess(IStudentDataAccess employeeComponent)
        {
            _studentData = employeeComponent;
        }

        public List<Student> GetStudents()
        {
            return _studentData.GetStudents();
        }

        public List<College> GetColleges()
        {
            return _studentData.GetColleges();
        }

        public List<Teacher> GetTeachers()
        {
            return _studentData.GetTeachers();
        }


        public int DeleteStudent(long studentId)
        {
            return _studentData.DeleteStudent(studentId);
        }


        public long InsertUpdateStudent(Student studentModel)
        {
            return _studentData.InsertUpdateStudent(studentModel);
        }


        public List<StudentModel> GetCustomStudentData()
        {
            return _studentData.GetCustomStudentData();
        }


        public List<Student> Pagination(int pageNumber)
        {
            return _studentData.Pagination(pageNumber);
        }
        public int pages()
        {
            return _studentData.pages();
        }

    
    }
}
