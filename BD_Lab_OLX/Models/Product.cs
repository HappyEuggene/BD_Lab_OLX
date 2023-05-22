using System.ComponentModel.DataAnnotations.Schema;

namespace BD_Lab_OLX.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        [ForeignKey("Categories")]
       
        public int CategoryId { get; set; }
        public Categories? Categories { get; set; }
        public int? UsersId { get; set; }    
        public Users? Users { get; set; }
        public List<Orders>? Orders { get; set; } = new List<Orders>();
    }
}
