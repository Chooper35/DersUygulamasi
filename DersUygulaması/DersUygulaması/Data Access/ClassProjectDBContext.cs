using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersUygulaması
{
    public class ClassProjectDBContext:DbContext
    {
        public DbSet<Öğrenci> ÖgrenciTbl { get; set; }
        public DbSet<Öğretmen> ÖğretmenTbl { get; set; }
        public DbSet<Soru> SoruTbl { get; set; }
        public DbSet<Konu> KonuTbl { get; set; }
        public DbSet<TestClass> testClasses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ClassProjectDBContext>(null);
            base.OnModelCreating(modelBuilder);
        }

    }
}
