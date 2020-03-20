using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
    public class Stylist
    {
        public Stylist()
        {
            this.Clients = new HashSet<Client>();
        }

        public int StylistId {get; set;}
        public string Name {get; set;}
        public string Specialties {get; set;}
        public virtual ICollection<Client> Clients { get; set; }

        
    }
}