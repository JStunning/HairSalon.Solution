using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
    public class Stylist
    {
        public string Name {get; set;}

        public string Specialties {get; set;}
        public int Id {get; set;}
    }
}