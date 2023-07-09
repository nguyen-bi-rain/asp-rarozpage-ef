using Microsoft.EntityFrameworkCore;
namespace razorweb.models;

public class MyBlogContext : DbContext{
    public MyBlogContext(DbContextOptions<MyBlogContext> options) : base(options)
    {
        // todo
    }
    public DbSet<Article> articles {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

/*
    dotnet aspnet-codegenerator razorpage -m razorweb.models.Article -dc razorweb.models.MyBlogContext -outDir Pages/Blog -udl --referenceScriptLibraries
*/