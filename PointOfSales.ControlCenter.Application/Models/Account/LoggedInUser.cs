using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSales.ControlCenter.Application.Models.Account
{
    public class LoggedInUser
    {
        public bool? HasVerifiedEmail { get; set; }
        public bool? TFAEnabled { get; set; }
        public string Token { get; set; }
    }
}
