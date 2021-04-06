using StudentEntities.CustomEntities;
using StudentEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentBO.Interface
{
    public interface IStudentBusinessAccess
    {

        public List<Student> GetStudents();

        public List<College> GetColleges();

        public List<Teacher> GetTeachers();

        public List<StudentModel> GetCustomStudentData();

        public int DeleteStudent(long studentId);

        public long InsertUpdateStudent(Student studentModel);

        public List<Student> Pagination(int pageNumber);
        public int pages();


    }
}
