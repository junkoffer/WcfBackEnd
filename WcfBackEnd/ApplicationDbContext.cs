namespace WcfBackEnd
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<ServiceCase> ServiceCases { get; set; }
                
        public ApplicationDbContext() : base("name=ApplicationDbContext")
        {
        }
                
        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {

            modelBuilder.Entity<ServiceCase>()

                .HasMany(c => c.ServiceCaseItems) //specificera 1-N-relation  

                .WithOptional() // ServiceCaseItem inte beh�ver referera tillbaka till ServiceCase 

                .WillCascadeOnDelete(true); // Om du tar bort ett ServiceCase s� ta relaterade CaseItems med 



            base.OnModelCreating(modelBuilder);

        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}