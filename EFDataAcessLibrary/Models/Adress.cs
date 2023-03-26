using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataAcessLibrary.Models
{
    public class Adress
    {
        public int Id { get; set; }

        [Required][MaxLength(200)] public string StreetAdress { get; set; } = "";

        [Required]
        [MaxLength(100)] 
        public string City { get; set; } = "";
        [Required]
        [MaxLength(50)]
        public string State { get; set; } = "";

        [Required]
        [MaxLength(10)] //
        [Column(TypeName = "varchar(10)")]
        public string ZipCode { get; set; } = "";
    }
}
