using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApi.Entities

{
    // [Keyless]
    public class Count
    {
         [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public string result { get; set; }
          public int count { get; set; }

    }
}