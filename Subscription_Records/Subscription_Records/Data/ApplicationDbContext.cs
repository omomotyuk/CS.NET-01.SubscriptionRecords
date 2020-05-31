using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Subscription_Records.Models;

namespace Subscription_Records.Data
{
    public class ApplicationDbContext : IdentityDbContext<Customer>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Subscription> Subscription { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            modelBuilder.Entity<Assist>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("GETDATE()");
            */

            Customer user = new Customer
            {
                FirstName = "First",
                LastName = "Admin",
                UserType = 1,
                StreetAddress = "123 Infinity Way",
                UserName = "first.admin@hcap.org",
                NormalizedUserName = "FIRST.ADMIN@HCAP.ORG",
                Email = "first.admin@hcap.org",
                NormalizedEmail = "FIRST.ADMIN@HCAP.ORG",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<Customer>();
            user.PasswordHash = passwordHash.HashPassword(user, "xxx-y-000-1");
            modelBuilder.Entity<Customer>().HasData(user);

            // Adding first record
            Subscription firstRecord = new Subscription
            {
                SubscriptionId = 101,
                SubscriptionDate = new DateTime(2010, 1, 01, 0, 0, 1, DateTimeKind.Local),
                Service = "card",
                Customer = "human",
                Account = 000010,
                ServiceStartDate =  new DateTime(2020, 5, 01, 0, 0, 1, DateTimeKind.Local),
                ServiceEndDate =    new DateTime(2020, 5, 31, 0, 0, 1, DateTimeKind.Local),
                BillingDate =       new DateTime(2020, 6, 01, 0, 0, 1, DateTimeKind.Local),
                PaymentDate =       new DateTime(2020, 6, 14, 0, 0, 1, DateTimeKind.Local),
                PaymentDueDate =    new DateTime(2020, 6, 15, 0, 0, 1, DateTimeKind.Local),
                Balance = 0.01
            };
            modelBuilder.Entity<Subscription>().HasData(firstRecord);
        }
    }
}
