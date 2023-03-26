using EFDataAcessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAcessLibrary.DataAccess
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options): base(options) 
        {
            
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Email> EmailAddresses { get; set; }
    }
}
