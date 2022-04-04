using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTask.Models
{
    public abstract class Vehicle
    {
        public abstract double DriveTime { get; set; }
        public abstract double DrivePath { get; set; }
        public double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public abstract void ShowInfo();

    }
}
