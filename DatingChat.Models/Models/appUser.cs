using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingChat.Models.Models
{
    public class appUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string userName { get; set; }
    }
}
