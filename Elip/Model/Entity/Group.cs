using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Elip.Model.Entity
{
    class Group
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NumberGroup { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<DataInGroup> DataInGroups { get; set; }

    }
}
