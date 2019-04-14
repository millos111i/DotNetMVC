using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCdotNetCRUDapp.Models
{
    public class MVCdotNetCRUDappContext : DbContext
    {
        public MVCdotNetCRUDappContext (DbContextOptions<MVCdotNetCRUDappContext> options)
            : base(options)
        {
        }

        public DbSet<MVCdotNetCRUDapp.Models.Movie> Movie { get; set; }
    }
}
