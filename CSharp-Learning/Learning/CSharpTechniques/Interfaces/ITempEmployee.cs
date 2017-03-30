using System;
using System.Collections.Generic;
using System.Text;
using Learning.CSharpTechniques;

namespace Interfaces
{
    interface ITempEmployee : IEmployee
    {
        decimal HourlyRate { get; set; }

        void ClockIn();
        void ClockOut();
        void TakeBreak();
    }
}