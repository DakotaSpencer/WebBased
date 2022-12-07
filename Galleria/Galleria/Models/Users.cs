﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Galleria.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DateOfBirth { get; set; }
        public byte[]? UserProfilePicture { get; set; }
        public string? Bio { get; set; }
        public string? Twitter { get; set; }
        public string? Instagram { get; set; }
        public string? Tumblr { get; set; }

        public Users()
        {

        }

        public Users(int userId, string firstName, string lastName, string userName, string email,
            string password, string dateOfBirth)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Email = email;
            Password = password;
            DateOfBirth = dateOfBirth;
        }

        public Users(int userId, string firstName, string lastName, string userName, string email, 
            string password, string dateOfBirth, byte[]? userProfilePicture, string? bio, 
            string? twitter, string? instagram, string? tumblr)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Email = email;
            Password = password;
            DateOfBirth = dateOfBirth;
            UserProfilePicture = userProfilePicture;
            Bio = bio;
            Twitter = twitter;
            Instagram = instagram;
            Tumblr = tumblr;
        }
    }
}