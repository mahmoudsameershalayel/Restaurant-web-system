using System.ComponentModel.DataAnnotations;

namespace Yummy.Models
{
    public class Aboutarticle
    {
        [Key]
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; } = "";
        public string ArticleBody { get; set; } = "";
        public string? List { get; set; } = "";
       
    }
}
