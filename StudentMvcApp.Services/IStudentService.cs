﻿using StudentMvcApp.Entities.DTOs;

namespace StudentMvcApp.Services
{
    public interface IStudentService
    {
        List<StudentDto> GetAll();
        StudentDto? GetById(int id);
        void Add(StudentDto student);
        void Update(StudentDto student);
        void Delete(int id);
    }
}
