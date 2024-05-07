using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace listClient.Models
{
    public class AppointmentType
    {
        [Key]
        public int AppointmentTypeId { get; set; }

        [Required]
        public string Type { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
