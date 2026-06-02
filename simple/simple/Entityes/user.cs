using System.ComponentModel.DataAnnotations;

namespace simple.Entityes
{
    public class user
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
