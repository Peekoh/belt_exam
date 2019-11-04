using Microsoft.EntityFrameworkCore;

namespace belt_exam.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> users {get; set;}
        public DbSet<RSVP> rsvps{get; set;}
        public DbSet<Event> events{get; set;}
    }
}