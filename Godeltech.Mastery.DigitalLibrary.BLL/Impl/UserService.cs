using System;
using System.Threading.Tasks;
using AutoMapper;
using Godeltech.Mastery.DigitalLibrary.BLL.Domain.DTO;
using Godeltech.Mastery.DigitalLibrary.BLL.Infrastructure.IdentityServices;
using Godeltech.Mastery.DigitalLibrary.BLL.Interfaces;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;
using Godeltech.Mastery.DigitalLibrary.DAL.Interfaces;
using Microsoft.AspNet.Identity;

namespace Godeltech.Mastery.DigitalLibrary.BLL.Impl
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfwork;

        public UserService(IUnitOfWork database)
        {
            _unitOfwork = database;
            SetEmailService();
            SetDefaultLockout();
            SetPasswordValidation();
        }

        // Configure validation logic for passwords
       

        public async Task<IdentityResult> CreateAsync(UserDto userDto)
        {
            var user = new ApplicationUsers { Email = userDto.Email, UserName = userDto.Email };
            var result = await _unitOfwork.UserManager.CreateAsync(user, userDto.Password);
            if (result.Succeeded)
            {
                await _unitOfwork.UserManager.AddToRoleAsync(user.Id, userDto.Role);
                await _unitOfwork.SaveAsync();
            }
            return result;
        }

        //email user manager services
       

        public async Task SendEmailAsync(string userId, string subject, string body)
        {
            await _unitOfwork.UserManager.SendEmailAsync(userId, subject, body);
        }

        public async Task<IdentityResult> ConfirmEmailAsunc(string userId, string code)
        {
           return await _unitOfwork.UserManager.ConfirmEmailAsync(userId, code);
        }

        public async Task<bool> IsEmailConfirmedAsync(string userId)
        {
            return await _unitOfwork.UserManager.IsEmailConfirmedAsync(userId);
        }

        public async Task<string> GeneratePasswordResetTokenAsync(string userId)
        {
            return await _unitOfwork.UserManager.GeneratePasswordResetTokenAsync(userId);
        }

        public async Task<string> GenerateEmailConfirmationTokenAsync(string userId)
        {
            return await _unitOfwork.UserManager.GenerateEmailConfirmationTokenAsync(userId);
        }

        public async Task<IdentityResult> ConfirmEmailAsync(string userId, string code)
        {
            return await _unitOfwork.UserManager.ConfirmEmailAsync(userId, code);
        }

        public async Task<UserDto> FindByNameAsync(string userName)
        {
            var appUser = await _unitOfwork.UserManager.FindByNameAsync(userName);
            return Mapper.Map<ApplicationUsers, UserDto>(appUser);
        }

        public async Task<IdentityResult> ResetPasswordAsync(string userId, string token, string newPassword)
        {
            return await _unitOfwork.UserManager.ResetPasswordAsync(userId, token, newPassword);
        }

        public void Dispose()
        {
            _unitOfwork?.Dispose();
        }

        //options for user manager
        private void SetPasswordValidation()
        {
            _unitOfwork.UserManager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true,
            };
        }

        private void SetDefaultLockout()
        {
            _unitOfwork.UserManager.UserLockoutEnabledByDefault = true;
            _unitOfwork.UserManager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            _unitOfwork.UserManager.MaxFailedAccessAttemptsBeforeLockout = 5;
        }

        private void SetEmailService()
        {
            _unitOfwork.UserManager.EmailService = new EmailService();
        }
    }
}
