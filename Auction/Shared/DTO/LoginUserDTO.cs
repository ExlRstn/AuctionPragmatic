﻿using System.ComponentModel.DataAnnotations;

namespace Shared.DTO;

public class LoginUserDTO
{
    [Required]
    [EmailAddress]
    public string Username { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}