using IdentityFromScratch.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityFromScratch.Data
{
    public class MyDbContext:IdentityDbContext<ApplicationUser,ApplicationRole,int>
    {
        public MyDbContext(DbContextOptions options):base(options)
        {

        }

    }
}
