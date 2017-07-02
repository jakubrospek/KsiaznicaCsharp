using KsiaznicaCsharp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KsiaznicaCsharp.DataAccessLayer
{
    public class DataContext : DbContext
    {

        public DataContext() : base("DataContext")
        {

        }

        static DataContext()
        {
            Database.SetInitializer<DataContext>(new DataInitializer());
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Friends> Friends { get; set; }

        public DbSet<Ratings> Book { get; set; }
        // dokończyć tą klasę na podstawie "Model danych Entity Framework (Code First)"
        // w kursie MVC w praktyce
    }
}