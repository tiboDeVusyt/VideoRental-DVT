using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoRental_DVT.Models
{
    public class Video
    {
        public int VideoId { get; set; }
        [Column(Order = 2)]

        public string VideoName { get; set; }
        [Required]
        [Column(Order = 4)]
        public double Price { get; set; }
        [Column(Order = 3)]
        public string Director { get; set; }
        [Required]
        public bool Rented { get; set; }

        [Column( Order = 7)]
        public int? RentId { get; set; }
        [Column(Order = 6)]
        public DateTime? ReturnDate { get; set; }
        public virtual Customer RentedTo { get; set; }
    }
}
