using PointOfSales.ControlCenter.Application.DTOs;
using PointOfSales.ControlCenter.Application.Models.Account;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.ControlCenter.Application.Interfaces
{
    public interface IAccountService
    {
        Task<Result<LoggedInUser>> GetValidTokenAsync(UserLogin userLogin);
    }
}
