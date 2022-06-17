using Microsoft.EntityFrameworkCore;
using TranslateApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TranslateApi.Data
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options) { }
       public DbSet<UpdateFiles> UpdateFiles { get; set; }


    }
}
