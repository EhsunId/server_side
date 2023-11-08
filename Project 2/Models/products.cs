using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Project_2.Models
{
    public class products
    {
        [Required]
        [Key]   
        public int P_id { get; set; }
        [StringLength(100)]
        [Required]
        public string P_name { get; set; }
        [StringLength(100)]
        public string? P_category { get; set; }
        public double? P_weight { get; set; }
        public double? P_height { get; set; }
        public DateTime? P_DateInsert { get; set; }
        [Required]
        public int P_price { get; set; }
        [Required]
        public bool P_available { get; set; }
        
        
    }
}