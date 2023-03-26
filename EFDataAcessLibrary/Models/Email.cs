using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAcessLibrary.Models
{
    public class Email
    {
        public int Id { get; set; }

        [Required()]
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string EmailAdress { get; set; } = "";
    }
}
