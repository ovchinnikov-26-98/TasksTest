namespace FirstTestTask.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RandomElementContext : DbContext
    {
        public RandomElementContext()
            : base("name=LocalDb")
        {
        }

        public virtual DbSet<RandomElements> RandomElements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
