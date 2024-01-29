using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;initial catalog=ApiDB; Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Room>(entry =>
            {
                entry.ToTable("Rooms", tb => tb.HasTrigger("RoomIncrease"));
                entry.ToTable("Rooms", tb => tb.HasTrigger("RoomDecrease"));
            });
            builder.Entity<Staff>(entry =>
            {
                entry.ToTable("Staffs", tb => tb.HasTrigger("StaffIncrease"));
                entry.ToTable("Staffs", tb => tb.HasTrigger("StaffDecrease"));
            });
            builder.Entity<Guest>(entry =>
            {
                entry.ToTable("Guests", tb => tb.HasTrigger("GuestIncrease"));
                entry.ToTable("Guests", tb => tb.HasTrigger("GuestDecrease"));
            });

            //builder.Entity<Room>().HasKey(r => r.RoomID);
            //builder.Entity<Service>().HasKey(s => s.ServiceID);
            //builder.Entity<Staff>().HasKey(st => st.StaffID);
            //builder.Entity<Subscribe>().HasKey(su => su.SubscribeID);
            //builder.Entity<Testimonial>().HasKey(t => t.TestimonialID);

        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
