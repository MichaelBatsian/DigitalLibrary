using System;
using System.Threading.Tasks;
using Godeltech.Mastery.DigitalLibrary.BLL.Domain.DTO;
using Microsoft.AspNet.Identity;

namespace Godeltech.Mastery.DigitalLibrary.BLL.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<IdentityResult> CreateAsync(UserDto userDto);
        Task SendEmailAsync(string userId, string subject, string body);
        Task<IdentityResult> ConfirmEmailAsunc(string userId, string code);
        Task<bool> IsEmailConfirmedAsync(string userId);
        Task<string> GeneratePasswordResetTokenAsync(string userId);
        Task<string> GenerateEmailConfirmationTokenAsync(string userId);
        Task<IdentityResult> ConfirmEmailAsync(string userId, string code);
        Task<UserDto> FindByNameAsync(string userName);
        Task<IdentityResult> ResetPasswordAsync(string userId, string token, string newPassword);

    }
}
