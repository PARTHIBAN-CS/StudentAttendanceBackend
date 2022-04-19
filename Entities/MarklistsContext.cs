// using Microsoft.EntityFrameworkCore;  
// namespace WebApi.Entities
// {     
// public class MarklistsContext : DbContext     
//   {         
//     public MarklistsContext(DbContextOptions<MarklistsContext> options)                 : base(options)         
// {         
// }       
//     public DbSet<Marklist>Marklists{ get; set; } 

//      protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         modelBuilder.HasSequence<int>("id", schema: "dbo")
//             .StartsAt(1)
//             .IncrementsBy(1);
          

//         modelBuilder.Entity<Marklist>()
//             .Property(o => o.id)
//             .HasDefaultValueSql("NEXT VALUE FOR dbo.Order_seq");
//     }
      
//    } 
// }