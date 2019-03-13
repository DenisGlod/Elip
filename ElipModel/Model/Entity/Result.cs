using System;
using System.ComponentModel.DataAnnotations;

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

        public int? UserId { get; set; }
        public virtual User User { get; set; }

        public int? DataInGroupId { get; set; }
        public virtual DataInGroup DataInGroup { get; set; }
    }
}
