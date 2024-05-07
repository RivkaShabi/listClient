using System;
using System.Collections.Generic;
using System.Linq;
using listClient.Models;
using listClient.Data;


namespace listClient.Services
{
    public class ClientService
    {
        public List<Client> GetClientListToAutoComplete()
        {
            return MockData.Clients;
        }
        public List<ClientListItem> GetClientList(int skip=-1, int take=-1, List<Client> clients = null)
        {
            var today = DateTime.Today;
            if (clients == null)
                clients = MockData.Clients;

            var appointments = MockData.Appointments;

            List<ClientListItem> clientList = new List<ClientListItem>();

            foreach (var client in clients)
            {
                var upcomingAppointment = appointments.Where(a => a.ClientId == client.ClientId && a.Date >= today)
                                                      .OrderBy(a => a.Date)
                                                      .FirstOrDefault();

                if (upcomingAppointment == null)
                {
                    upcomingAppointment = appointments.Where(a => a.ClientId == client.ClientId)
                                                      .OrderByDescending(a => a.Date)
                                                      .FirstOrDefault();
                }

                ClientListItem listItem = new ClientListItem
                {
                    ClientId = client.ClientId,
                    ClientName = client.Name,
                    NextAppointmentDate = upcomingAppointment != null ? upcomingAppointment.Date : DateTime.MinValue,
                    AppointmentType = upcomingAppointment != null ?
                                        MockData.AppointmentTypes.FirstOrDefault(a => a.AppointmentTypeId == upcomingAppointment.AppointmentTypeId)?.Type :
                                        "No appointment",
                };

                clientList.Add(listItem);
            }

            if (skip >= 0 && take >= 0)
            {
                clientList = clientList
                    .OrderByDescending(item => item.NextAppointmentDate >= DateTime.Now)
                    .ThenBy(item => Math.Abs((DateTime.Now - item.NextAppointmentDate).Ticks))
                    .Skip(skip)
                    .Take(take)
                    .ToList();

            }
            return clientList;
        }

        public List<ClientListItem> SearchClients(string searchTerm)
        {
            var searchResults = MockData.Clients.Where(c => c.Name.ToLower().Contains(searchTerm.ToLower()) ||
                                                       c.ClientId.ToString() == searchTerm)
                                                      .ToList();
            var clients = new List<ClientListItem>();
            if (searchResults.Count == MockData.Clients.Count)
                clients = GetClientList(0, 10, searchResults);
            else
                clients = GetClientList(clients: searchResults);
            return clients;

        }
    } 
    public class ClientListItem
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public DateTime NextAppointmentDate { get; set; }
        public string AppointmentType { get; set; }
    }
}      

