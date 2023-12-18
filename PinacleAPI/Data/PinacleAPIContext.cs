using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PinacleAPI;

namespace PinacleAPI.Data
{
    public class PinacleAPIContext : DbContext
    {
        public PinacleAPIContext (DbContextOptions<PinacleAPIContext> options)
            : base(options)
        {
        }

        public DbSet<PinacleAPI.Client> Client { get; set; } = default!;
    }
}
