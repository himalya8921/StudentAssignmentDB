using StudentEntities.CustomEntities;
using StudentEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDO.Interface
{
    public interface IStudentDataAccess
    {

        
        public List<Student> GetStudents();

        public List<College> GetColleges();

        public List<Teacher> GetTeachers();

        public int DeleteStudent(long studentId);

        public long InsertUpdateStudent(Student studentModel);

        public List<StudentModel> GetCustomStudentData();

        public List<Student> Pagination(int pageNumber);

        public int pages();

    }
}
