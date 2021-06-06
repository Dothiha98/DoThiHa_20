using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoThiHa_20.Models
{
    public partial class LTQLDb : DbContext
    {
        private object modleBuilder;

        public LTQLDb()
            : base("name=LTQLDb1")
        {
        }
        public virtual DbSet <TinhThanh> TinhThanhs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modleBuilder.Entity<TinhThanh>()
                .Property(e => e.MaTinhThanh)
                .IsUnicode(false);

            modleBuilder.Entity<TinhThanh>()
               .Property(e => e.TenTinhThanh)
               .IsUnicode(false);

        }
    }
}
