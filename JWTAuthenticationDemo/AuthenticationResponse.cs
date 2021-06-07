﻿namespace JWTAuthenticationDemo
{
    public class AuthenticationResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string Username { get; set; }

        public string Token { get; set; }

        public AuthenticationResponse(User user,string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            Username = user.Username;
            Token = token;

        }
    }
}
