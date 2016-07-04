using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebContextDb : DbContext
    {
        public WebContextDb() : base("name=WebDeveloperConnectionString")
        {
            //Database.SetInitializer(new WebDeveloperInitializer());
        }
        
        public DbSet<Address> Address { get; set; }
        public DbSet<AddressType> AddressType { get; set; }
        public DbSet<BusinessEntity> BusinessEntity { get; set; }
        public DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }
        public DbSet<ContactType> ContactType { get; set; }
        public DbSet<CountryRegion> CountryRegion { get; set; }
        public DbSet<EmailAddress> EmailAddress { get; set; }
        public DbSet<Password> Password { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonPhone> PersonPhone { get; set; }
        public DbSet<PhoneNumberType> PhoneNumberType { get; set; }
        public DbSet<StateProvince> StateProvince { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
