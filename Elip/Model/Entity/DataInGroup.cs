using System.ComponentModel.DataAnnotations;

namespace Elip.Model.Entity
{
    class DataInGroup
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
        public Group Group { get; set; }

    }
}
