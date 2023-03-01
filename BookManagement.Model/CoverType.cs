using System.ComponentModel.DataAnnotations;

namespace BookManagement.Model
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CoverName { get; set; }

    }
}