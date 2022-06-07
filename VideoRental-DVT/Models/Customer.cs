using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoRental_DVT.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        [NotMapped]
        public List<int> RentIds { get; set; }
        public ICollection<Video> RentedVideos { get; set; }

    }
}
