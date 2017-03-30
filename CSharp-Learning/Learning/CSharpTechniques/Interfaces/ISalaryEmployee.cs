using System;
using System.Collections.Generic;
using System.Text;
using Learning.CSharpTechniques;

namespace Interfaces
{
    interface ISalaryEmployee : IEmployee
    {
        decimal Salary { get; set; }

        void TakeVacation();
        void DoPeerReview();
        void ChooseCareerPath();
    }
}