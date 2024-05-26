using System;
using System.ComponentModel.DataAnnotations;

namespace PoetryWebsite.Models
{
    public class Poetry
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Author { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        public string Content { get; set; } = string.Empty;

        public DateTime PostedDate { get; set; } = DateTime.Now;

    }
}
