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
        private readonly ProfileService service;
        //private EmployeeViewModel model = new EmployeeViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new EmployeeViewModel();
            service = new ProfileService();
        }

        private void btnSave_Clicked_1(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Address = EmpAddress.Text;
            emp.Address2 = EmpAddress2.Text;
            emp.Birthdate = EmpBirthdate.Date;
            emp.City = EmpCity.Text;
            emp.City2 = EmpCity2.Text;
            emp.Description = lblEmpDescription.Text;
            emp.CompEmail = EmpCompMail.Text;
            emp.Country = EmpCountry.Text;
            emp.Country2 = EmpCountry2.Text;
            emp.Gender = EmpGender.Text;
            emp.Mobile = long.Parse(EmpMobile.Text.ToString());
            emp.Name = EmpName.Text;
            emp.NationalNo = long.Parse(EmpNationalNo.Text.ToString());
            emp.Organization = lblEmpOrg.Text;
            emp.Phone = long.Parse(EmpPhone1.Text.ToString());
            emp.Phone2 = long.Parse(EmpPhone2.Text.ToString());
            emp.ZipCode = EmpZipCode.Text;
            var t = Task.Run(() => service.Update(int.Parse(EmpId.Text.ToString()), emp));
            t.Wait();
            if (emp != null)
            {
                DisplayAlert("Message", "This Profile is updated successfully", "OK");
            }
        }
    }
}
