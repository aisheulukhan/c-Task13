using System;
using System.Collections.Generic;
using System.Text;
using VehicleTask.Interface;

namespace VehicleTask.Models
{
    public class Plane : Vehicle, IWheel, IEngine
    {
        private int _wingLength;
        private double _wheelthickness;
        private double _horsepower;
        private double _tanksize;
        private double _currentoil;
        private string _fueltype;
        private double _drivetime;
        private double _drivepath;
        public int WingLength
        {
            get
            {
                return _wingLength;
            }
            set
            {
                if (value > 0 || value < 150)
                {
                    _wingLength = value;
                }
            }

        }
        public double WhellThickness
        {
            get
            {
                return _wheelthickness;
            }
            set
            {
                if (value > 0)
                {
                    _wheelthickness = value;
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
                if (value > 0 || value < 1000)
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
        public Plane(int winglength, double whellthickness, double horsepower, double tanksize, double currentoil, string fueltype, double drivetime, double drivepath)
        {
            WingLength = winglength;
            WhellThickness = whellthickness;
            HorsePower = horsepower;
            TankSize = tanksize;
            CurrentOil = currentoil;
            FuelType = fueltype;
            DriveTime = drivetime;
            DrivePath = drivepath;
        }
        public double LeftFuelAmount()
        {
            return TankSize - CurrentOil;
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
