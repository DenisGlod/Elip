using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ElipAdmin.Model.Entity
{
    public class Group
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NumberGroup { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<DataInGroup> DataInGroups { get; set; }

        public Group()
        {
            Users = new BindingList<User>();
            DataInGroups = new BindingList<DataInGroup>();
        }
    }
}
