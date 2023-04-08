﻿namespace Auth.API.DTOs
{
    public class AuthResponseDTO
    {
        public bool IsAuthSuccessful { get; set; }
        public string? ErrorMessage { get; set; }
        public string? Token { get; set; }
    }
}
