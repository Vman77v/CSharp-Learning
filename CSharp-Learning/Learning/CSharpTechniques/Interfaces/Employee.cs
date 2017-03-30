using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    static class Employee
    {
        public static ITempEmployee TemporaryWorker(string firstName, string lastName, decimal hourlyRate)
        {
            var emp = (ITempEmployee)new Worker(firstName, lastName);
            emp.HourlyRate = hourlyRate;
            return emp;
        }

        public static ISalaryEmployee SalaryWorker(string firstName, string lastName, decimal salary)
        {
            var emp = (ISalaryEmployee)new Worker(firstName, lastName);
            emp.Salary = salary;
            return emp;
        }

        public static IHourlyEmployee HourlyWorker(string firstName, string lastName, decimal hourlyRate)
        {
            var emp = (IHourlyEmployee)new Worker(firstName, lastName);
            emp.HourlyRate = hourlyRate;
            return emp;
        }

        private class Worker : ITempEmployee, ISalaryEmployee, IHourlyEmployee
        {
            public Worker(string firstName, string lastName)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal Salary { get; set; }
            public decimal HourlyRate { get; set; }

            public void ClockIn()
            {
                throw new NotImplementedException();
            }

            public void ClockOut()
            {
                throw new NotImplementedException();
            }

            public void TakeBreak()
            {
                throw new NotImplementedException();
            }

            public void TakeVacation()
            {
                throw new NotImplementedException();
            }

            public void DoPeerReview()
            {
                throw new NotImplementedException();
            }

            public void ChooseCareerPath()
            {
                throw new NotImplementedException();
            }
        }
    }
}