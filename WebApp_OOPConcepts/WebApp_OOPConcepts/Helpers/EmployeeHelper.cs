using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts.Helpers
{
    public class EmployeeHelper
    {
        private Employee _salaryEmployee;
        private Employee _commissionEmployee;
        private Employee _hourlyEmployee;
        private Employee _baseCommissionEmployee;

        public EmployeeHelper(Employee salaryEmployee, Employee commissionEmployee,
            Employee hEmployee, Employee baseCommissionEmployee)
        {
            _salaryEmployee = salaryEmployee;
            _commissionEmployee = commissionEmployee;
            _hourlyEmployee = hEmployee;
            _baseCommissionEmployee = baseCommissionEmployee;
        }

        public decimal GetPayrollFromActiveEmployees()
        {
            ICollection<Employee> employees = new List<Employee>()
                {
                    _salaryEmployee,
                    _commissionEmployee,
                    _hourlyEmployee,
                    _baseCommissionEmployee
                };

            decimal payroll = 0;

            foreach (Employee employee in employees)
            {
                if (employee.IsActive == true)
                {
                    Console.WriteLine(employee);
                    Console.WriteLine(" ");
                    payroll += employee.GetValueToPay();
                }
            }

            return payroll;
        }
    }
}
