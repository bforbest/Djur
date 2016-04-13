using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Djur.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public static List<UserModel> DefaultUsers()
        {
            return new List<UserModel>()
            {
                new UserModel()
                {
                    Name = "ali",
                    Password = "12345",
                    Admin = false
                },
                new UserModel()
                {
                    Name="alex",
                    Password="pass",
                    Admin = true
                }
            };
        }
    }
}