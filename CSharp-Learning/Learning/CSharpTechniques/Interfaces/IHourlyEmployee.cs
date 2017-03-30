using System;
using System.Collections.Generic;
using System.Text;
using Learning.CSharpTechniques;

namespace Interfaces
{
    interface IHourlyEmployee : IEmployee
    {
        decimal HourlyRate { get; set; }

        void TakeVacation();
        void ClockIn();
        void ClockOut();
        void TakeBreak();
    }
}