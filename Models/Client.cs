using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace listClient.Models
{
    public class Client
     {
        [Key]
        public int ClientId { get; set; }

        [Required]
        public string Name { get; set; }

        //public ICollection<Appointment> Appointments { get; set; }
    }

}
