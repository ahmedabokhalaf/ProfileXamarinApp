using Profile.Models;
using Profile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Profile.ViewModel
{
    public class EmployeeViewModel
    {

        private readonly IProfileService service;
        public Employee Employee { get; set; }
        
        public EmployeeViewModel()
        {
            service = new ProfileService();
            var t = Task.Run(() => LoadEmployee());
            t.Wait();
        }

        public async Task LoadEmployee()
        {
            try
            {
                this.Employee = await service.GetEmployee(3);
            }
            catch (Exception ex)
            {
            }
        }

        public async Task UpdateEmployee(int id)
        {
            try
            {
                id = 3;
                var emp = await service.GetEmployee(id);
                await service.Update(id, emp);
            }catch(Exception ex)
            {

            }
        }
    }
}
