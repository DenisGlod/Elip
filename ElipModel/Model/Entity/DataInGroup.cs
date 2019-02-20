using System.ComponentModel.DataAnnotations;

namespace ElipAdmin.Model.Entity
{
    public class DataInGroup
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string Data { get; set; }

        [Required]
        public string DataType { get; set; }

        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
