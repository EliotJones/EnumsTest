namespace EnumsTest.Configurations
{
    using EnumsTest.Entities;
    using System.Data.Entity.ModelConfiguration;

    public class OwnerConfiguration : EntityTypeConfiguration<Owner>
    {
        public OwnerConfiguration()
        {
            ToTable("Owner");

            HasKey<int>(o => o.Id);
        }
    }
}
