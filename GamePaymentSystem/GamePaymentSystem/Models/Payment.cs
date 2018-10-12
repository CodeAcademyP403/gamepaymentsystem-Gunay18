using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamePaymentSystem.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public string UserIP { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }

        public double Price { get; set; }

        public DateTime PaymentTime { get; set; }

        public bool Status { get; set; }
    }
}
