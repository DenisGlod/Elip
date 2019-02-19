using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ElipAdmin.Model.Entity
{
    public class Group
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NumberGroup { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<DataInGroup> DataInGroups { get; set; }

    }
}
