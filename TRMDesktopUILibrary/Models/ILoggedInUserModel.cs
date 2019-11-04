﻿using System;

namespace TRMDesktopUILibrary.Models
{
    public interface ILoggedInUserModel
    {
        DateTime CreateDate { get; set; }
        string EmailAdress { get; set; }
        string FirstName { get; set; }
        string Id { get; set; }
        string LastName { get; set; }
        string Token { get; set; }
    }
}