using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace VetClinicApp
{
    class PetContext : DbContext
    {
        public PetContext()
            : base("Dbconnection")
        { }

        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<PetContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }

    class DoctorContext : DbContext
    {
        public DoctorContext()
            : base("Dbconnection")
        { }

        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DoctorContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }

    class ImagesContext : DbContext
    {
        public ImagesContext()
            : base("Dbconnection")
        { }

        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ImagesContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }

    class OwnerContext : DbContext
    {
        public OwnerContext()
            : base("Dbconnection")
        { }

        public DbSet<Owner> Owners { get; set; }

    }

    class TreatmentCaseContext : DbContext
    {
        public TreatmentCaseContext()
            : base("Dbconnection")
        { }

        public DbSet<TreatmentСase> treatmentСases { get; set; }

    }
    class ServiceContext : DbContext
    {
        public ServiceContext()
            : base("Dbconnection")
        { }

        public DbSet<Service> services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ServiceContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}

