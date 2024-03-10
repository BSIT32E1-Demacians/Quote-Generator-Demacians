using System.ComponentModel.DataAnnotations;

namespace QuoteGenerator.Models
{
    public class Quote
    {
        [Key]
        public int QuoteId { get; set; }
        [Required]
        public string QuoteText { get; set; }
        public string Author { get; set;}
    }
}
