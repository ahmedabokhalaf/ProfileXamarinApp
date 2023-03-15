using Profile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Services
{
    public interface IProfileService
    {
        Task<Employee> GetEmployee(int id);
        Task Update(int id, Employee emp);
    }
}
