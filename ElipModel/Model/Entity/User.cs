using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElipAdmin.Model.Entity
{
    public class User
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

        public string MiddleName { get; set; }

        [Required]
        public string Role { get; set; }

        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public virtual ICollection<DataInGroup> DataInGroups { get; set; }

        public User() { }

        public User(bool flagDataInGroup)
        {
            DataInGroups = new BindingList<DataInGroup>();
        }
    }
}
