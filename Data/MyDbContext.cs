using Microsoft.EntityFrameworkCore;
using regist.Models;

namespace regist.Data{
    public class MyDbContext :DbContext{
        public MyDbContext(DbContextOptions<MyDbContext> option):base(option)
        {
        }

        public DbSet<Member> Members {get; set;}
    }
}