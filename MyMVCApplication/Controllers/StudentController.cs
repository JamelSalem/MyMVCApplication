using Microsoft.Ajax.Utilities;
using MyMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class StudentController : Controller
    { // GET: Student 

       
            public ActionResult Edit(int Id)
        {

         
            // dans des applications réelles on récupère la liste à partir d’une base de données 

            //Get the student from studentList sample collection for demo purpose. 
            //Get the student from the database in the real application 
            var  std = studentList.Where(s => s.StudentId == Id).FirstOrDefault(); return View(std);

        }
        IList<Student> studentList = new List<Student> { new Student() { StudentId = 1, StudentName = "John", Age = 18 },
            new Student() { StudentId = 2, StudentName = "Steve", Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill", Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }};
        public ActionResult Index()
        {
            
            return View(studentList);
            // dans des applications réelles on récupère la liste à partir d’une base de données
        }
        [HttpPost]
        public ActionResult Edit(FormCollection values)
        { //écrire ici le code de modification d’un Student
           // var id=Request["StudentId"];
            var name=values["StudentName"];
            var Age=values["Age"];
          //  var age = std.Age;
            //studentList.(std);
            return RedirectToAction("Index"); }
            

        }
}