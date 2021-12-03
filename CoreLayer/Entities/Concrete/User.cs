using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreLayer.Entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [MaxLength(500)]
        public byte[] PasswordHash { get; set; }
        [MaxLength(500)]
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
    }
}
