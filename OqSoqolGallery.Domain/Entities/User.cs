using OqSoqolGallery.Domain.Commons;

namespace OqSoqolGallery.Domain.Entities;

public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public decimal Balance { get; set; }
}
