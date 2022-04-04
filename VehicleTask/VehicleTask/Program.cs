using System;
using VehicleTask.CustomException;
using VehicleTask.Models;

namespace VehicleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int doorcount = 0;
            string wincode = "";
            double horsepower = 0;
            double tanksize = 0;
            double currentoil = 0;
            string fueltype = "";
            double whellthickness = 0;
            string transmissionkind = "";
            double drivetime = 0;
            double drivepath = 0;
            string pedalkind = "";
            int winglength = 0;
            int key;
            do
            {
            Start:
                try
                {
                    Console.WriteLine("1.Maşın ");
                    Console.WriteLine("2.Velosiped");
                    Console.WriteLine("3.Təyyarə");
                    Console.WriteLine("4.End");
                    Console.WriteLine("5.Reqem daxil edin");
                    key = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                    goto Start;
                }
                switch (key)
                {
                    case 1:
                        InputCar(ref doorcount, ref wincode, ref horsepower, ref tanksize, ref currentoil, ref fueltype, ref whellthickness, ref transmissionkind, ref drivetime, ref drivepath);
                        Car car = new Car(doorcount, wincode, horsepower, tanksize, currentoil, fueltype, whellthickness, transmissionkind, drivetime, drivepath);
                        car.ShowInfo();
                        Console.WriteLine($"Average Speed - {car.AverageSpeed()}");
                        Console.WriteLine($"Left Fuel Amount - {car.LeftFuelAmount()}");
                        
                        break;
                    case 2:
                        InputBicycle(ref pedalkind, ref whellthickness, ref transmissionkind, ref drivetime, ref drivepath);
                        Bicycle bicycle = new Bicycle(pedalkind, whellthickness, transmissionkind, drivetime, drivepath);
                        Console.WriteLine($"Average Speed - {bicycle.AverageSpeed()}");
                        break;
                    case 3:
                        InputPlane(ref winglength, ref whellthickness, ref horsepower, ref tanksize, ref currentoil, ref fueltype, ref drivetime, ref drivepath);
                        Plane plane = new Plane(winglength, whellthickness, horsepower, tanksize, currentoil, fueltype, drivetime, drivepath);
                        plane.ShowInfo();
                        Console.WriteLine($"Average Speed - {plane.AverageSpeed()}");
                        Console.WriteLine($"Left Fuel Amount - {plane.LeftFuelAmount()}");

                        break;
                    default:
                    case 4:
                        Console.WriteLine("End"); 
                        break;
                }

            } while (key != 4);



        }
        static void InputCar(ref int doorcount, ref string wincode, ref double horsepower, ref double tanksize, ref double currentoil, ref string fueltype, ref double whellthickness, ref string transmissionkind, ref double drivetime, ref double drivepath)
        {
            InputCDoorCount(ref doorcount);
            InputCWinCode(ref wincode);
            InputCHorsePower(ref horsepower);
            InputCTankSize(ref tanksize);
            InputCCurrentOil(ref currentoil);
            InputCFuelType(ref fueltype);
            InputCWhellThickness(ref whellthickness);
            InputCtransmissionkind(ref transmissionkind);
            InputCdrivetime(ref drivetime);
            InputCdrivepath(ref drivepath);

        }
        static void InputCDoorCount(ref int doorcount)
        {
        Start:
            try
            {
                Console.Write("Qapı sayını daxil edin: ");
                doorcount = Convert.ToInt32(Console.ReadLine());
                if (doorcount < 0 || doorcount > 4)
                {
                    throw new NotAvailableException("Qapı sayını düzgün daxil edin.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputCWinCode(ref string wincode)
        {
        Start:
            try
            {
                Console.Write("Vin kodu daxil edin: ");
                wincode = Console.ReadLine();
                if (string.IsNullOrEmpty(wincode) || string.IsNullOrWhiteSpace(wincode))
                {
                    throw new NotAvailableException("Win kod mütləq daxil olunmalıdır.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputCHorsePower(ref double horsepower)
        {
        Start:
            try
            {
                Console.Write("At gücünü daxil edin: ");
                horsepower = Convert.ToDouble(Console.ReadLine());
                if (horsepower < 0)
                {
                    throw new NotAvailableException("At gücünü düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }

        static double tsize = 0;
        static void InputCTankSize(ref double tanksize)
        {
        Start:
            try
            {
                Console.Write("Yağ tutumunu daxil edin: ");
                tanksize = Convert.ToDouble(Console.ReadLine());
                tsize = tanksize;

                if (tanksize < 0 || tanksize > 200)
                {
                    throw new NotAvailableException("Yağ tutumunu düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputCCurrentOil(ref double currentoil)
        {
        Start:
            try
            {
                Console.Write("Cari yağ miqdarını daxil edin: ");
                currentoil = Convert.ToDouble(Console.ReadLine());
                if (currentoil < 0 || tsize < currentoil)
                {
                    throw new NotAvailableException("Cari yağ miqdarını düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputCFuelType(ref string fueltype)
        {
        Start:
            try
            {
                Console.Write("Yağ növünü daxil edin: ");
                fueltype = Console.ReadLine();
                if (string.IsNullOrEmpty(fueltype) || string.IsNullOrWhiteSpace(fueltype))
                {
                    throw new NotAvailableException("Yağ növü mütləq daxil olunmalıdır.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız hərf daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputCWhellThickness(ref double whellthickness)
        {
        Start:
            try
            {
                Console.Write("Təkərin qalınlığını daxil edin: ");
                whellthickness = Convert.ToDouble(Console.ReadLine());
                if (whellthickness < 0)
                {
                    throw new NotAvailableException("Təkərin qalınlığını düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputCtransmissionkind(ref string transmissionkind)
        {
        Start:
            try
            {
                Console.Write("Ötürmə növünü daxil edin: ");
                transmissionkind = Console.ReadLine();
                if (true)
                {
                    if (string.IsNullOrEmpty(transmissionkind) || string.IsNullOrWhiteSpace(transmissionkind))
                    {
                        throw new NotAvailableException("Ötürmə növü mütləq daxil olunmalıdır.");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız hərf daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputCdrivetime(ref double drivetime)
        {
        Start:
            try
            {
                Console.Write("Gedilən vaxtı daxil edin: ");
                drivetime = Convert.ToDouble(Console.ReadLine());
                if (drivetime < 0)
                {
                    throw new NotAvailableException("Gedilən vaxtı düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputCdrivepath(ref double drivepath)
        {
        Start:
            try
            {
                Console.Write("Gedilən yolu daxil edin: ");
                drivepath = Convert.ToDouble(Console.ReadLine());
                if (drivepath < 0)
                {
                    throw new NotAvailableException("Gedilən yolu düzgün daxil edin!");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputBicycle(ref string pedalkind, ref double whellthickness, ref string transmissionkind, ref double drivetime, ref double drivepath)
        {
            InputBPedalKind(ref pedalkind);
            InputBWhellThickness(ref whellthickness);
            InputBTransmissionKind(ref transmissionkind);
            InputBDriveTime(ref drivetime);
            InputBDrivePath(ref drivepath);
        }
        static void InputBPedalKind(ref string pedalkind)
        {
        Start:
            try
            {
                Console.Write("Pedalın növünü daxil edin: ");
                pedalkind = Console.ReadLine();
                if (string.IsNullOrEmpty(pedalkind) || string.IsNullOrWhiteSpace(pedalkind))
                {
                    throw new NotAvailableException("Pedal növü mütləq daxil olunmalıdır.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız hərf daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }

        }
        static void InputBWhellThickness(ref double whellthickness)
        {
        Start:
            try
            {
                Console.Write("Təkərin qalınlığını daxil edin: ");
                whellthickness = Convert.ToDouble(Console.ReadLine());
                if (whellthickness < 0)
                {
                    throw new NotAvailableException("Təkərin qalınlığını düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputBTransmissionKind(ref string transmissionkind)
        {
        Start:
            try
            {
                Console.Write("Ötürmə növünü daxil edin: ");
                transmissionkind = Console.ReadLine();
                if (true)
                {
                    if (string.IsNullOrEmpty(transmissionkind) || string.IsNullOrWhiteSpace(transmissionkind))
                    {
                        throw new NotAvailableException("Ötürmə növü mütləq daxil olunmalıdır.");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız hərf daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputBDriveTime(ref double drivetime)
        {
        Start:
            try
            {
                Console.Write("Gedilən vaxtı daxil edin: ");
                drivetime = Convert.ToDouble(Console.ReadLine());
                if (drivetime < 0)
                {
                    throw new NotAvailableException("Gedilən vaxtı düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputBDrivePath(ref double drivepath)
        {
        Start:
            try
            {
                Console.Write("Gedilən yolu daxil edin: ");
                drivepath = Convert.ToDouble(Console.ReadLine());
                if (drivepath < 0)
                {
                    throw new NotAvailableException("Gedilən yolu düzgün daxil edin!");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputPlane(ref int winglength,ref double whellthickness,ref double horsepower,ref double tanksize,ref double currentoil,ref string fueltype,ref double drivetime,ref double drivepath)
        {
            InputPWingLenght(ref winglength);
            InputPWhellThickness(ref whellthickness);
            InputPHorsePower(ref horsepower);
            InputPTankSize(ref tanksize);
            InputPCurrentOil(ref currentoil);
            InputPFuelType(ref fueltype);
            InputPDriveTime(ref drivetime);
            InputPDrivePath(ref drivepath);
        }
        static void InputPWingLenght(ref int winglength)
        {
        Start:
            try
            {
                Console.Write("Qanad uzunluğunu daxil edin: ");
                winglength = Convert.ToInt32(Console.ReadLine());
                if (winglength < 0 || winglength > 150)
                {
                    throw new NotAvailableException("Qanad uzunluğunu düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputPWhellThickness (ref double whellthickness)
        {
        Start:
            try
            {
                Console.Write("Təkərin qalınlığını daxil edin: ");
                whellthickness = Convert.ToDouble(Console.ReadLine());
                if (whellthickness < 0)
                {
                    throw new NotAvailableException("Təkərin qalınlığını düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputPHorsePower(ref double horsepower)
        {
        Start:
            try
            {
                Console.Write("At gücünü daxil edin: ");
                horsepower = Convert.ToDouble(Console.ReadLine());
                if (horsepower < 0)
                {
                    throw new NotAvailableException("At gücünü düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
       static double ttsize = 0;
        static void InputPTankSize (ref double tanksize)
        {
        Start:
            try
            {
                Console.Write("Yağ tutumunu daxil edin: ");
                tanksize = Convert.ToDouble(Console.ReadLine());
                ttsize = tanksize;

                if (tanksize < 0 || tanksize > 1000)
                {
                    throw new NotAvailableException("Yağ tutumunu düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputPCurrentOil(ref double currentoil)
        {
        Start:
            try
            {
                Console.Write("Cari yağ miqdarını daxil edin: ");
                currentoil = Convert.ToDouble(Console.ReadLine());
                if (currentoil < 0 || ttsize < currentoil)
                {
                    throw new NotAvailableException("Cari yağ miqdarını düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputPFuelType(ref string fueltype)
        {
        Start:
            try
            {
                Console.Write("Yağ növünü daxil edin: ");
                fueltype = Console.ReadLine();
                if (string.IsNullOrEmpty(fueltype) || string.IsNullOrWhiteSpace(fueltype))
                {
                    throw new NotAvailableException("Yağ növünü düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız hərf daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputPDriveTime(ref double drivetime)
        {
        Start:
            try
            {
                Console.Write("Gedilən vaxtı daxil edin: ");
                drivetime = Convert.ToDouble(Console.ReadLine());
                if (drivetime < 0)
                {
                    throw new NotAvailableException("Gedilən vaxtı düzgün daxil edin!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputPDrivePath(ref double drivepath)
        {
        Start:
            try
            {
                Console.Write("Gedilən yolu daxil edin: ");
                drivepath = Convert.ToDouble(Console.ReadLine());
                if (drivepath < 0)
                {
                    throw new NotAvailableException("Gedilən yolu düzgün daxil edin");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }


}   }