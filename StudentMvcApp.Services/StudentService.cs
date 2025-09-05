using StudentMvcApp.Data.Models;
using StudentMvcApp.Entities.DTOs;

namespace StudentMvcApp.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentDbContext _context;

        public StudentService(StudentDbContext context)
        {
            _context = context;
        }

        public List<StudentDto> GetAll()
        {
            return _context.Students
                .Select(s => new StudentDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Age = s.Age,
                    Course = s.Course
                })
                .ToList();
        }

        public StudentDto? GetById(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return null;

            return new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                Course = student.Course
            };
        }

        public void Add(StudentDto student)
        {
            var entity = new Student
            {
                Name = student.Name,
                Age = student.Age,
                Course = student.Course
            };
            _context.Students.Add(entity);
            _context.SaveChanges();
        }

        public void Update(StudentDto student)
        {
            var entity = _context.Students.Find(student.Id);
            if (entity == null) return;

            entity.Name = student.Name;
            entity.Age = student.Age;
            entity.Course = student.Course;

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Students.Find(id);
            if (entity == null) return;

            _context.Students.Remove(entity);
            _context.SaveChanges();
        }
    }
}
