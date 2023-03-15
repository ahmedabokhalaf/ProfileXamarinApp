using Newtonsoft.Json;
using Profile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Profile.Services
{
    public class ProfileService : IProfileService
    {
        private HttpClient client = new HttpClient();

        public ProfileService()
        {
            client.BaseAddress = new Uri("http://10.0.2.2:5210/");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        
        public async Task Update(int id, Employee emp)
        { 
            var response = await client.PutAsync($"Employees/{id}",
                new StringContent(System.Text.Json.JsonSerializer.Serialize(emp), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var response = await client.GetAsync($"Employees/{id}");
            response.EnsureSuccessStatusCode();
            var responseAsString = await response.Content.ReadAsStringAsync();
            var emp = System.Text.Json.JsonSerializer.Deserialize<Employee>(
                responseAsString, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return emp;
        }
    }
}
