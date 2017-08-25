using Firebase.Xamarin.Database;
using Firebase.Xamarin.Database.Query;
using Firebase.Xamarin.Token;
using StudentAppFirebase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentAppFirebase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentPage : ContentPage
    {
        public StudentPage()
        {
            InitializeComponent();
        }
       
  

        private void Button_Clicked(object sender, EventArgs e)
        {
            GetFromDatabase();
        }

        public List<StudentDetails> _studentList;

        public List<StudentDetails> StudentList
        {

            get { return _studentList; }
            set
            {
                _studentList = value;
                OnPropertyChanged();
            }

        }

        //Get Request


        public async   Task GetFromDatabase()
        {
            //  Student myUserData = new Student(); myUserData.Name = "user1"; myUserData.ParentName = "pswd1"; myUserData.RollNo = "766483";


            var firebase = new FirebaseClient("https://studentappfirebase-667c5.firebaseio.com/");

            var items = await firebase
              .Child("Subchild")
              .OrderByKey()
              .WithAuth(FirebaseAuth)
              .LimitToFirst(2)
              // . PostAsync(new StudentDetails() { Name = "RD",ParentName="Xyz",RollNo=""});
              .OnceAsync<StudentDetails>();

            //Do whatever you need with items such as
             //StudentDetails i= items.

            foreach ( var item in items)
            {
            //    //Access values by item.Object.<field_name> and item.Key

                  
            }

        
        }


        public async Task PostToDatabase()
        {

            var firebase = new FirebaseClient("https://yourdatabase.firebaseio.com/");

            // add new item to list of data 
            var item = await firebase
              .Child("Subchild")
              //.WithAuth("<Authentication Token>") // <-- Add Auth token if required. Auth instructions further down in readme.
              .PostAsync(new StudentDetails());

            // note that there is another overload for the PostAsync method which delegates the new key generation to the client

           // Console.WriteLine($"Key for the new item: {item.Key}");

          
            
            // add new item directly to the specified location (this will overwrite whatever data already exists at that location)


            //var item = await firebase
            //  .Child("yourentity")
            //  .Child("Ricardo")
            //  //.WithAuth("<Authentication Token>") // <-- Add Auth token if required. Auth instructions further down in readme.
            //  .PutAsync(new YourObject());

        }




        public static Func<string> Converttostring(string token)
        {

            System.Func<string> tokenresp = token.ToString;
            return tokenresp;
        }

        public static string FirebaseAuth()
        {

            var tokenGenerator = new TokenGenerator("AIzaSyDhxe5x5aiiHdxlDC0XtIncM-Ja1upWrXY");
            var authPayload = new Dictionary<string, object>()
        {
          { "uid", "1" },
          { "some", "arbitrary" },
          { "data", "here" }
        };
            return tokenGenerator.CreateToken(authPayload);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }
    }
}


