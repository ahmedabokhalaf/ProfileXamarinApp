using Microsoft.Extensions.DependencyInjection;
using Profile.Models;
using Profile.Services;
using Profile.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Profile
{
    public partial class MainPage : ContentPage
    {
        //private ObservableCollection<Employee> database;
        //private int indx;
        //private ProfileService service;
        private EmployeeViewModel model = new EmployeeViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new EmployeeViewModel();
            //service = new ProfileService();
        }

        private void btnSave_Clicked_1(object sender, EventArgs e)
        {
            var t = Task.Run(() => model.UpdateEmployee(3));
            t.Wait();
            //database[indx].Name = EmpName.Text;
            //database[indx].NationalNo = long.Parse(EmpNationalNo.Text.ToString());
            //database[indx].Phone = long.Parse(EmpPhone1.Text.ToString());
            //database[indx].CompEmail = EmpCompMail.Text;
            //database[indx].Birthdate = EmpBirthdate.Date;
            //database[indx].Gender = EmpGender.Text;
            //database[indx].Address = EmpAddress.Text;
            //database[indx].Country = EmpCountry.Text;
            //database[indx].City = EmpCity.Text;
            //database[indx].ZipCode = EmpZipCode.Text;
            //database[indx].Phone2 = long.Parse(EmpPhone2.Text.ToString());
            //database[indx].Mobile = long.Parse(EmpMobile.Text.ToString());
            //database[indx].Address2 = EmpAddress2.Text;
            //database[indx].City2 = EmpCity2.Text;
            //database[indx].Country2 = EmpCountry2.Text;
            //bool res = Database.SaveEmployee(database[indx]);
            //if (res)
            //{
            //    DisplayAlert("Message", "This Profile is updated successfully", "OK");
            //}
        }
    }
}
