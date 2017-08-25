using StudentAppFirebase.Models;
using StudentAppFirebase.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppFirebase.ViewModel
{


    public class StudentDetailViewModel : INotifyPropertyChanged
    {

        public string nam = "";

        public List<Student> _studentList;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<Student> StudentList
        {

            get { return _studentList; }
            set
            {
                _studentList = value;
                OnPropertyChanged();
            }

        }

        private void OnPropertyChanged()
        {
            throw new NotImplementedException();
        }

        public StudentDetailViewModel()
        {
            var Studentservices = new StudentServices();
            StudentList = Studentservices.Getstudent();

        }
    }
}