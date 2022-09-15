using Microsoft.AspNetCore.Mvc;
using Student.Data;
using Student.Models;

namespace Student.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _db;
        public StudentController(StudentDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //var studentInfo = new Dictionary<string, List<StudentInfo>>();
            //studentInfo.Add("ailed", _db.StudentInfos.Where(s => s.Marks < 35).ToList());
            //studentInfo.Add("Passed", _db.StudentInfos.Where(s => s.Marks > 35 && s.Marks < 50).ToList());
            //studentInfo.Add("Good", _db.StudentInfos.Where(s => s.Marks > 50 && s.Marks < 75).ToList());
            //studentInfo.Add("Excellent", _db.StudentInfos.Where(s => s.Marks > 75).ToList());
            //var studentList = _db.StudentInfos.Any() ? _db.StudentInfos.ToList() : new List<StudentInfo>();
            IEnumerable<StudentInfo> studentList = _db.StudentInfos;
            return View(studentList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentInfo studentInfo)
        {
            _db.Add(studentInfo);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _db.StudentInfos.First(x => x.Id == id);
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(StudentInfo studentInfo)
        {
            _db.Update(studentInfo);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var student = _db.StudentInfos.First(x => x.Id == id);
            return View(student);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _db.StudentInfos.First(x => x.Id == id);
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(StudentInfo studentInfo)
        {
            _db.Remove(studentInfo);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
