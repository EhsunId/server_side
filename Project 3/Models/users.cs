using System.ComponentModel.DataAnnotations;
using System.Reflection;
namespace Project_3.Models
{
    public class users
    {
        [Key]   
        public int P_id { get; set; }
        public string U_name { get; set; }
        public string U_family { get; set; }
        public string U_age { get; set; }
    }
}