using StudentAppFirebase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppFirebase.Services
{
   public class StudentServices
    {


        public List<Student> Getstudent()
        {


            var List = new List<Student>()
            {
                new Student{
                    Name="Nammdev",
                    Images="URL LINK",
                    Videos="link",
                    Feedback="good"


                },new Student{

                 Name="Nammdev1",
                    Images="URL LINK",
                    Videos="link",
                    Feedback="good"}

            };

            return List;

        }


    }
}
