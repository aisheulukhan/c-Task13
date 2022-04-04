using System;
using System.Collections.Generic;
using System.Text;
using VehicleTask.Interface;

namespace VehicleTask.Models
{
    public class Car : Vehicle, IEngine, IWheel, ITransmission
    {
        private int _doorcount;
        private string _wincode;
        private double _horsepower;
        private double _tanksize;
        private double _currentoil;
        private string _fueltype;
        private double _whellthickness;
        private string _transmissionkind;
        private double _drivetime;
        private double _drivepath;
        public int DoorCount
        {
            get
            {
                return _doorcount;
            }
            set
            {
                if (value > 0 || value <= 4)
                {
                    _doorcount = value;
                }
            }
        }
        public string WinCode
        {
            get
            {
                return _wincode;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _wincode = value;
                }
            }
        }
        public double HorsePower
        {
            get
            {
                return _horsepower;
            }
            set
            {
                if (value > 0)
                {
                    _horsepower = value;
                }
            }
        }
        public double TankSize
        {
            get
            {
                return _tanksize;
            }
            set
            {
                if (value > 0 || value < 200)
                {
                    _tanksize = value;
                }
            }
        }
        public double CurrentOil
        {
            get
            {
                return _currentoil;
            }
            set
            {
                if (value > 0 || value <= TankSize)
                {
                    _currentoil = value;
                }
            }
        }
        public string FuelType
        {
            get
            {
                return _fueltype;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _fueltype = value;
                }
            }
        }
        public double WhellThickness
        {
            get
            {
                return _whellthickness;
            }
            set
            {
                if (value > 0)
                {
                    _whellthickness = value;
                }
            }
        }
        public string TransmissionKind
        {
            get
            {
                return _transmissionkind;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _transmissionkind = value;
                }
            }
        }
        public override double DriveTime
        {
            get
            {
                return _drivetime;
            }
            set
            {
                if (value > 0)
                {
                    _drivetime = value;
                }
            }
        }
        public override double DrivePath
        {
            get
            {
                return _drivepath;
            }
            set
            {
                if (value > 0)
                {
                    _drivepath = value;
                }
            }
        }
        public double LeftFuelAmount()
        {
            return TankSize - CurrentOil;
        }
        public Car(int doorcount, string wincode, double horsepower, double tanksize, double currentoil, string fueltype, double whellthickness, string transmissionkind, double drivetime, double drivepath)
        {
            DoorCount = doorcount;
            WinCode = wincode;
            HorsePower = horsepower;
            TankSize = tanksize;
            CurrentOil = currentoil;
            FuelType = fueltype;
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
            Console.WriteLine($"Average Speed - {AverageSpeed()}");
            Console.WriteLine($"Left Fuel Amount - {LeftFuelAmount()}");
            Console.WriteLine("----------------------------------------------------------");

        }
    }
}
