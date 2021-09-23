using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotSystemPayment.Services
{
    interface ITaxService
    {
        double Tax(double amount);
    }
}
