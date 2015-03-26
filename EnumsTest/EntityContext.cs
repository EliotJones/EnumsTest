namespace EnumsTest
{
    using EnumsTest.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq.Expressions;

    public class EntityContext : DbContext
    {
        public DbSet<BonsaiTree> BonsaiTrees { get; set; }
        public DbSet<Owner> Owners { get; set; }

        public EntityContext()
            : base(nameOrConnectionString: "DefaultConnection")
        {
            Database.SetInitializer<EntityContext>(null);
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.ComplexType<Genus>().Ignore(g => g.Value);

            modelBuilder.Configurations.AddFromAssembly(typeof(EntityContext).Assembly);
            modelBuilder.Conventions.AddFromAssembly(typeof(EntityContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
