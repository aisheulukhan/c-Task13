using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTask.CustomException
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException(string message) : base(message) { }
    }
}
