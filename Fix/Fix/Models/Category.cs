using System.ComponentModel.DataAnnotations;

namespace Fix.Models
{
    public class Category
    {
        [Key]
        public int ItemID { get; set; }
        public string? Art { get; set; }
        public float Byd { get; set; }
        public float Price { get; set; }
        public DateTime Dat { get; set; }

    }
}
