using Microsoft.AspNetCore.Mvc;
using StudentMvcApp.Services;

namespace StudentMvcApp.Web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students);
        }
    }
}
