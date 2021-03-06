﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Orchard.Users.Models;

namespace Orchard.Users.Services
{
    public interface IUserService
    {
        Task<bool> CreateUserAsync(User user, string password, Action<string, string> reportError);
    }
}