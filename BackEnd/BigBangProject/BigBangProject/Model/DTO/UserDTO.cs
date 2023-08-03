﻿namespace BigBangProject.Model.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string Role { get; set; }=string.Empty;
        public string? Token { get; set; }
    }
}
