using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetAPI.Entities;

[Table("User")]
public sealed class User
{
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        [MaxLength(30)]
        [Column("MobileNumber")]
        public string? Mobile { get; set; }
}