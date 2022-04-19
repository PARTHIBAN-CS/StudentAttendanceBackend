using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApi.Entities

{
    // [Keyless]
    public class HomeLogin
    {
         [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int id { get; set; }
          public string username { get; set; }

          public string password { get; set; }

    }
}