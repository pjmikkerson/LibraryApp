using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    [NotMapped]
    public class BookRecommendationViewModel
    {
        public Book Book { get; set; }
        public Recommendation Recommendation { get; set; }
    }
}
