using System;
using System.ComponentModel.DataAnnotations;

namespace ForexApi
{
    public class RateData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Partner { get; set; }
        [Required]
        public int Supply { get; set; }
        [Required]
        public decimal Rate { get; set; }
    }
}
