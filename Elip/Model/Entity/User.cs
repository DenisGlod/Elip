using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElipAdmin.Model.Entity
{
    class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Index(IsUnique = true)]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string Role { get; set; }

        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<DataInGroup> DataInGroups { get; set; }

    }
}
