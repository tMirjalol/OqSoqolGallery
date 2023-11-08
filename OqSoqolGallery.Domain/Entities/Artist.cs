using OqSoqolGallery.Domain.Enums;
using System.Data;

namespace OqSoqolGallery.Domain.Entities;

public class Artist
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public decimal Balance { get; set; }
    public Roles Role { get; set; }
}
