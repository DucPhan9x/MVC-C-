
using System.Collections.Generic;
using StudentMvc.Models;

namespace StudentMvc.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudentById(int studentId);
        void AddNewStudent(Student student);
        void EditStudent(Student student);
        void DeleteStudent(int studentId);
    }
}