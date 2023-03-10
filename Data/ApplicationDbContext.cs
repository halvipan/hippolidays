using hippolidays.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace hippolidays.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<hippolidays.Models.Request> Request { get; set; } = default!;
    public DbSet<hippolidays.Models.RequestType> RequestType { get; set; } = default!;
    public DbSet<hippolidays.Models.RequestStatus> RequestStatus { get; set; } = default!;
}
