using System;
using System.Collections.Generic;
using System.Text;
using VehicleTask.Interface;

namespace VehicleTask.Models
{
    public class Bicycle : Vehicle, IWheel, ITransmission
    {
        private string _pedalkind;
        private double _driveTime;
        private double _drivePath;
        private string _transmissionKind;
        private double _wheelThickness;
        public string PedalKind
        {
            get
            {
                return _pedalkind;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _pedalkind = value;
                }
            }
        }
        public double WhellThickness
        {
            get
            {
                return _wheelThickness;
            }
            set
            {
                if (value > 0)
                {
                    _wheelThickness = value;
                }
            }
        }
        public string TransmissionKind
        {
            get
            {
                return _transmissionKind;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _transmissionKind = value;
                }
            }
        }
        public override double DriveTime
        {
            get
            {
                return _driveTime;
            }
            set
            {
                if (value > 0)
                {
                    _driveTime = value;
                }
            }
        }
        public override double DrivePath
        {
            get
            {
                return _drivePath;
            }
            set
            {
                if (value > 0)
                {
                    _drivePath = value;
                }
            }
        }
        public Bicycle(string pedalkind, double whellthickness, string transmissionkind, double drivetime, double drivepath)
        {
            PedalKind = pedalkind;
            WhellThickness = whellthickness;
            TransmissionKind = transmissionkind;
            DriveTime = drivetime;
            DrivePath = drivepath;
        }
        public override void ShowInfo()
        {
            foreach (var item in this.GetType().GetProperties())
            {
                Console.WriteLine($"{item.Name} - {item.GetValue(this)}");
            }
            
            Console.WriteLine("----------------------------------------------------------");

        }
    }
}
