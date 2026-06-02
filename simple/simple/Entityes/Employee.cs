using System.ComponentModel.DataAnnotations;

namespace simple.Entityes
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModificationDate { get; set; }
        public DateTime? DOB { get; set; }
        public string? Positios { get; set; }
    }
}
