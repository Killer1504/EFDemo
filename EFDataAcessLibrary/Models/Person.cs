using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAcessLibrary.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required()]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required()]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required()]
        public int Age { get; set; }

        public List<Email> EmailAddresses { get; set; } = new List<Email>();
        public List<Adress> Addresses { get; set; } = new List<Adress>();
    }
}
