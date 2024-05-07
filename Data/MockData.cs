using System;
using System.Collections.Generic;
using listClient.Models;

namespace listClient.Data
{
    public static class MockData
    {
        public static List<Client> Clients { get; set; } = new List<Client>
        {
            new Client { ClientId = 1, Name = "John Doe"},
            new Client { ClientId = 2, Name = "Alice Johnson"},
            new Client { ClientId = 3, Name = "Bob Williams"},
            new Client { ClientId = 4, Name = "Emily Brown"},
            new Client { ClientId = 5, Name = "Michael Davis"},
            new Client { ClientId = 6, Name = "Olivia Garcia"},
            new Client { ClientId = 7, Name = "William Martinez"},
            new Client { ClientId = 8, Name = "Sophia Robinson"},
            new Client { ClientId = 9, Name = "James Clark"},
            new Client { ClientId = 10, Name = "Charlotte Hernandez"},
            new Client { ClientId = 11, Name = "Daniel Lee"},
            new Client { ClientId = 12, Name = "Emma Walker"},
            new Client { ClientId = 13, Name = "Ethan King"}
        };

        public static List<AppointmentType> AppointmentTypes { get; set; } = new List<AppointmentType>
        {
            new AppointmentType { AppointmentTypeId = 1, Type = "Checkup" },
            new AppointmentType { AppointmentTypeId = 2, Type = "Follow-up" },
            new AppointmentType { AppointmentTypeId = 3, Type = "Consultation" },
            new AppointmentType { AppointmentTypeId = 4, Type = "Treatment" },
            new AppointmentType { AppointmentTypeId = 5, Type = "Physical Examination" },
            new AppointmentType { AppointmentTypeId = 6, Type = "Therapy Session" }
        };

        public static List<Appointment> Appointments { get; set; } = new List<Appointment>
        {
            new Appointment { AppointmentId = 1, Date = DateTime.Now.AddDays(5).Date, ClientId = 1, AppointmentTypeId = 1 },
            new Appointment { AppointmentId = 2, Date = DateTime.Now.AddDays(2).Date, ClientId = 2, AppointmentTypeId = 2 },
            new Appointment { AppointmentId = 3, Date = DateTime.Now.AddDays(3).Date, ClientId = 3, AppointmentTypeId = 3 },
            new Appointment { AppointmentId = 4, Date = DateTime.Now.AddDays(4).Date, ClientId = 4, AppointmentTypeId = 4 },
            new Appointment { AppointmentId = 6, Date = DateTime.Now.AddDays(6).Date, ClientId = 6, AppointmentTypeId = 5 },
            new Appointment { AppointmentId = 7, Date = DateTime.Now.AddDays(-7).Date, ClientId = 7, AppointmentTypeId = 1 },
            new Appointment { AppointmentId = 8, Date = DateTime.Now.AddDays(8).Date, ClientId = 8, AppointmentTypeId = 2 },
            new Appointment { AppointmentId = 9, Date = DateTime.Now.AddDays(9).Date, ClientId = 9, AppointmentTypeId = 3 },
            new Appointment { AppointmentId = 10, Date = DateTime.Now.AddDays(6).Date, ClientId = 10, AppointmentTypeId = 4 },
            new Appointment { AppointmentId = 11, Date = DateTime.Now.AddDays(11).Date, ClientId = 11, AppointmentTypeId = 5 },
            new Appointment { AppointmentId = 12, Date = DateTime.Now.AddDays(12).Date, ClientId = 12, AppointmentTypeId = 6 },
            new Appointment { AppointmentId = 13, Date = DateTime.Now.AddDays(13).Date, ClientId = 13, AppointmentTypeId = 1 }        ,
            new Appointment { AppointmentId = 14, Date = DateTime.Now.AddDays(11).Date, ClientId = 13, AppointmentTypeId = 6 }        ,
            new Appointment { AppointmentId = 15, Date = DateTime.Now.AddDays(15).Date, ClientId = 13, AppointmentTypeId = 3 },
            new Appointment { AppointmentId = 16, Date = DateTime.Now.AddDays(-1).Date, ClientId = 8, AppointmentTypeId = 4 },
        };
    }
}
