// using Microsoft.EntityFrameworkCore;  
// namespace WebApi.Entities {     
// public class MarksContext : DbContext     
//   {         
//     public MarksContext(DbContextOptions<MarksContext> options)                            
//     : base(options)         
// {         
// }       
//     public DbSet<Mark> Marks { get; set; }     
//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//        modelBuilder.HasSequence<int>("id", schema: "dbo")
//             .StartsAt(1)
//             .IncrementsBy(1);
//         modelBuilder.Entity<Mark>()
//             .Property(o => o.id)
//             .HasDefaultValueSql("NEXT VALUE FOR dbo.Order_seq");
//     }
//    } 
// }