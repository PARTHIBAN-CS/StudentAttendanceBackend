using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WebApi.Entities
{
    
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  rollno { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }

         
        public string gender { get; set; }
        public string phoneno { get; set; }

    }
    
}