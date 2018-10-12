using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamePaymentSystem.Models
{
    public class GamePaymentDbContext: DbContext
    {
        public GamePaymentDbContext(DbContextOptions<GamePaymentDbContext> dbContextOptions):base(dbContextOptions) { }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
    }
}
