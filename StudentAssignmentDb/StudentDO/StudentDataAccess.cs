using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StudentDO.Interface;
using StudentEntities.CustomEntities;
using StudentEntities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace StudentDO
{
    public class StudentDataAccess : IStudentDataAccess
    {

        private readonly StudentDbContext _studentDbContext;

        public StudentDataAccess(StudentDbContext employeeDbContext)
        {
            _studentDbContext = employeeDbContext;
        }

        public List<Student> GetStudentsCourses()
        {
            return _studentDbContext.Student.ToList();
        }

        public List<College> GetColleges()
        {
            return _studentDbContext.College.ToList();
        }
        public List<Teacher> GetTeachers()
        {
            return _studentDbContext.Teacher.ToList();
        }

        public List<Student> GetStudents()
        {
            return _studentDbContext.Student.FromSqlRaw("[dbo].[GetStudentData]").ToList();
        }


        public long InsertUpdateStudent(Student studentModel)
        {
            long result = 0;
            SqlParameter resultParameter = new SqlParameter();
            try
            {
                resultParameter.ParameterName = "@Result";
                resultParameter.Direction = ParameterDirection.Output;
                resultParameter.SqlDbType = SqlDbType.BigInt;
                var id = 0;
                _studentDbContext.Database.ExecuteSqlRaw("[dbo].[AddUpdateStudent] @StudentId,@StudentName,@StudentCity,@StudentState,@FathersName,@LastName,@TeacherId,@CollegeId,@Result OUT ",
                    new SqlParameter("@StudentId", studentModel.StudentId),
                    new SqlParameter("@StudentName", studentModel.StudentName),
                    new SqlParameter("@StudentCity", studentModel.StudentCity),
                    new SqlParameter("@StudentState", studentModel.StudentState),
                    new SqlParameter("@FathersName", studentModel.FathersName),
                    new SqlParameter("@LastName", studentModel.LastName),
                    new SqlParameter("@TeacherId", studentModel.TeacherId),
                    new SqlParameter("@CollegeId", studentModel.CollegeId),
                    resultParameter
                    );
                if (Convert.ToInt32(resultParameter.Value) > 0)
                    result = Convert.ToInt32(resultParameter.Value);
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;

        }

        public int DeleteStudent(long studentId)
        {
            var Obj = _studentDbContext.Student.FirstOrDefault(x => x.StudentId == studentId);
            _studentDbContext.Student.Remove(Obj);
            return _studentDbContext.SaveChanges();
        }


        public List<StudentModel> GetCustomStudentData()
        {
            return _studentDbContext.StudentModel.FromSqlRaw("[dbo].[GetAllData]").ToList();
        }

        public List<Student> Pagination(int pageNumber)
        {
            List<Student> stdList = _studentDbContext.Student.FromSqlRaw("exec [dbo].[GetPageWiseStudentDetails] " + pageNumber + ",3").ToList();
            return stdList;
        }

        public int pages()
        {
            int total = _studentDbContext.Student.Count();
            int pageNumber;
            if (total / 3 == 0)
            {
                pageNumber = total / 3;
            }
            else
            {
                pageNumber = total / 3 + 1;
            }
            return pageNumber;
        }
   



}
}
