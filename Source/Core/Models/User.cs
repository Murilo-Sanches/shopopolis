using System.ComponentModel.DataAnnotations.Schema;

namespace Shopopolis.Source.Core.Models;

public class User
{
    [Column("id")]
    public long Id { get; set; }

    [Column("email", TypeName = "VARCHAR(255)")]

    public string Email { get; set; }

    [Column("password", TypeName = "VARCHAR(255)")]
    public string Password { get; set; }
}
