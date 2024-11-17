using System;
using System.Collections.Generic;

namespace Auth_MicroService_DBFA_Project.Models;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int? CountryId { get; set; }

    public string? Country { get; set; }

    public virtual Country? CountryNavigation { get; set; }
}
