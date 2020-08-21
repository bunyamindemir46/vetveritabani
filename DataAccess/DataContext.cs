using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vetveritabani.Entity;

namespace vetveritabani.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        DbSet<Personel> Personel { get; set; }
        DbSet<Hayvan> Hayvan { get; set; }
        DbSet<Muayene> Muayene { get; set; }
    }
}
