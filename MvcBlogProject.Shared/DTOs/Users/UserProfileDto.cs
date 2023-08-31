﻿using Microsoft.AspNetCore.Http;
using MvcBlogProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.Shared.DTOs.Users
{
    public class UserProfileDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public IFormFile? photo { get; set; }
        public string CurrentPassword { get; set; }
        public string? NewPassword { get; set; }
        public Image Image { get; set; }
    }
}