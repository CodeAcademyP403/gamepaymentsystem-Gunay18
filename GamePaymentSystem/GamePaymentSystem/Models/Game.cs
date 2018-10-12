using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamePaymentSystem.Models
{
    public class Game
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double MinPrice { get; set; }

        [Required]
        public double MaxPrice { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public string PhotoPath { get; set; }

    }
}
