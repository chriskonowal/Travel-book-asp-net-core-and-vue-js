using System;
using System.Collections.Generic;
using System.Text;

namespace Travel.Application.Dtos.User
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
        public AuthenticateResponse(Domain.Entities.User user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            UserName = user.UserName;
            Token = token;
            Email = user.Email;
        }
    }
}
