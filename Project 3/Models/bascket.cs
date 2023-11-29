using System.ComponentModel.DataAnnotations;
using System.Reflection;
namespace Project_3.Models
{
    public class bascket
    {
        [Key]   
        public int B_id { get; set; }
        public string B_name { get; set; }
        public string B_category { get; set; }
        public string B_price { get; set; }
    }
}