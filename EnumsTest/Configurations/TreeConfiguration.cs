namespace EnumsTest.Configurations
{
    using EnumsTest.Entities;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;

    public class TreeConfiguration : EntityTypeConfiguration<BonsaiTree>
    {
        public TreeConfiguration()
        {
            ToTable("Tree");

            HasKey<int>(b => b.Id);

            Property(b => b.Genus.DisplayName).HasColumnName("Genus");

            Property(DelegateHelper.GetPropertyAccessor<BonsaiTree, string>("Name"));

            HasMany<Owner>(DelegateHelper.GetPropertyAccessor<BonsaiTree, ICollection<Owner>>("Owners"))
                .WithMany(o => o.Trees)
                .Map(x => 
                {
                    x.MapLeftKey("TreeId");
                    x.MapRightKey("OwnerId");
                    x.ToTable("TreeOwner");
                });

            Ignore(p => p.Ownerss);
        }
    }
}
