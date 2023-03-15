using Profile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Profile.Services
{
    public static class Database
    {

        //private static ObservableCollection<Employee> data = new ObservableCollection<Employee>(initData);

        //private static List<Employee> initData
        //{
        //    get
        //    {
        //        return new List<Employee>
        //        {
        //            new Employee
        //            {
        //                Id=1,
        //                ImagePath="showimage.png",
        //                Name="Ahmed Khalaf Hassan",
        //                Organization = "Org 51",
        //                Description = "Director of Department",
        //                NationalNo = 2970111111111111,
        //                Phone = 9839288348,
        //                CompEmail = "AhmedKH@hitstechnology.com",
        //                Birthdate = DateTime.Now,
        //                Gender = "Male",
        //                Address = "Zahraa Naser City",
        //                Country = "Egypt",
        //                City = "Cairo",
        //                ZipCode = "kjakl123",
        //                Phone2 = 11221122,
        //                Mobile = 01234567891,
        //                Address2 = "Maadi",
        //                City2 = "Assiut",
        //                Country2 = "alk"
        //            }
        //        };
        //    }
        //}

        //public static ObservableCollection<Employee> GetAllEmployees()
        //{
        //    return data;
        //}

        //public static bool SaveEmployee(Employee employee)
        //{
        //    int indx = data.IndexOf(employee);
        //    if (indx == -1)
        //    {
        //        //Insert New Employee
        //        int newId = data[data.Count - 1].Id + 1;
        //        employee.Id = newId;
        //        data.Add(employee);
        //    }
        //    else
        //    {
        //        //Update
        //        data[indx] = employee;
        //    }
        //    return true;
        //}
    }
}
