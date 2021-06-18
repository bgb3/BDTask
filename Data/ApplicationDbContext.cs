using Birthday.Entities;
using Birthday.EntityConfiguration;
using Birthday.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Birthday.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Gift> Gifts { get; set; }
        public DbSet<Voting> Votings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmployeeConfiguration());
            builder.ApplyConfiguration(new GiftConfiguration());
            builder.ApplyConfiguration(new VotingConfiguration());


            base.OnModelCreating(builder);


            // seeding users into database
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {                    
                    UserName = "angel@testemail.com",
                    NormalizedUserName = "ANGEL@TESTEMAIL.COM",
                    NormalizedEmail = "ANGEL@TESTEMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    Email = "angel@testemail.com",
                    FullName = "Angel",
                    BirthDate = new DateTime(1982, 12, 09)
                },
                 new ApplicationUser
                 {
                     UserName = "petur@testemail.com",
                     NormalizedUserName = "PETUR@TESTEMAIL.COM",
                     NormalizedEmail = "PETER@TESTEMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     Email = "petur@testemail.com",
                     FullName = "Petur",
                     BirthDate = new DateTime(1995, 06, 07)
                 },
                  new ApplicationUser
                  {                      
                      UserName = "mitko@testemail.com",
                      NormalizedUserName = "MITKO@TESTEMAIL.COM",
                      NormalizedEmail = "MITKO@TESTEMAIL.COM",
                      PasswordHash = hasher.HashPassword(null, "123456"),
                      Email = "mitko@testemail.com",
                      FullName = "Mitko",
                      BirthDate = new DateTime(1989, 11, 22)
                  }
            );

            builder.Entity<Gift>().HasData(
                new Gift
                {
                    GiftId = 1,
                    GiftName = "Boat",
                    Image = "~/images/boat.jpg"
                },
                new Gift
                {
                    GiftId = 2,
                    GiftName = "Camper",
                    Image = "~/images/camper.jpg"
                },
                new Gift
                {
                    GiftId = 3,
                    GiftName = "Cessna",
                    Image = "~/images/cessna.jpg"
                }
            );

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Birthday.Entities.VotingDetails> VotingDetails { get; set; }
    }
}
