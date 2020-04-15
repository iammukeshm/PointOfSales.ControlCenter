using CoreLibrary.Helpers;
using PointOfSales.ControlCenter.Application.DTOs;
using PointOfSales.ControlCenter.Application.Interfaces;
using PointOfSales.ControlCenter.Application.Models.Account;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.ControlCenter.Infrastructure.ApiService.Services
{
    public class AccountService : IAccountService
    {
        public async Task<Result<LoggedInUser>> GetValidTokenAsync(UserLogin userLogin)
        {
            var data = new UserLogin { Email = "iammukeshm@gmail.com", Password = "Pa$$w0rd." };
            ApiHelper api = new ApiHelper("https://localhost:44348/");
            var result = await api.PostAsync<Result<LoggedInUser>>("api/Account/login", data);
            return result;
        }
    }
}
