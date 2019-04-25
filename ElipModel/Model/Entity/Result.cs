using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElipModel.Model.Entity
{
    public class Result
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Mark { get; set; }

        [Required]
        public DateTime DateTimeResult { get; set; }

        [Required]
        [Column(TypeName = "varbinary(max)")]
        public byte[] AnswerData { get; set; }

        [Required]
        [DefaultValue("Не проверено")]
        public string Status { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }

        public int? DataInGroupId { get; set; }
        public virtual DataInGroup DataInGroup { get; set; }

        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
