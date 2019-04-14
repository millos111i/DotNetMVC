using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCdotNetCRUDapp.Models
{
    public class MVCdotNetCRUDappContext : DbContext
    {
        private Func<Type, object> getRequiredService;

        public MVCdotNetCRUDappContext (DbContextOptions<MVCdotNetCRUDappContext> options)
            : base(options)
        {
        }

        public MVCdotNetCRUDappContext(Func<Type, object> getRequiredService)
        {
            this.getRequiredService = getRequiredService;
        }

        public DbSet<MVCdotNetCRUDapp.Models.Movie> Movie { get; set; }
    }
}
