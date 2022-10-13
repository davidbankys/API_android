using System;
using EmployeeApplication.Models;




namespace EmployeeApplication.Services
{
    interface IEmployeeDataStore<T>
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync(int count);
        
    }
}

