using Course.Models;
using Course.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;

namespace Course.Controllers
{
    public class StudentController : Controller
    {
        public List<Student> Students { get; private set; }
        public Group Groups { get; private set; }

        public IActionResult Index()
        {
            Student student = new Student();
            {
                student.Id = 1;
                student.Name = "Lala";
                student.GroupId = 1;
            };
            Student student2 = new Student();
            student2.Id = 2;
            student2.Name = "Bella";
            student2.GroupId = 2;

            Student student3 = new Student();
            student2.Id = 3;
            student2.Name = "Gul";
            student2.GroupId = 2;

            List<Student> list = new List<Student>();
            list.Add(student);
            list.Add(student2);
            list.Add(student3);

            Group group = new Group();
            group.Id = 1;
            group.Name = "Academy";

            Group group2 = new Group();
            group.Id = 2;
            group.Name = "Lotos";

            HomeVM vm = new HomeVM();
            {
                Students = list;
                Groups = group;
            }   

            
            return View();
        }
    }

    public IActionResult Detail(int id)
    {
       
    }

    public IActionResult GetStudentWithGroupId(int groupid)
    {
        
    }

}
