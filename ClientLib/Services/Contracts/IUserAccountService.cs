using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseLib.DTOs;
using BaseLib.Responses;

namespace ClientLib.Services.Contracts
{
    public interface IUserAccountService
    {
        Task<GeneralResponse> CreateAsync(Register user);
        Task<LoginResponse> SignInAsync(Login user);
        Task<LoginResponse> RefreshTokenAsync(RefreshToken token);
        Task<WeatherForecast[]> GetWeatherForecast();
    }
}