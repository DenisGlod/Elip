using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElipModel.Model.Entity
{
    public class DataInGroup
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        [Column(TypeName = "varbinary(max)")]
        public byte[] Data { get; set; }

        [Required]
        public string DataType { get; set; }

        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
