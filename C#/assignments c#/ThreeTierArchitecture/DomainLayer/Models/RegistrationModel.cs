﻿namespace DomainLayer.Models
{
    public class RegistrationModel
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IsStudent { get; set; }
    }
}