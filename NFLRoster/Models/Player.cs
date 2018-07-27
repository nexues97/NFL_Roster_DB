using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NFLRoster.Models
{
    public class Player
    {
        [DisplayName("Player Id")]
        public int PlayerId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Position { get; set; }
        [DisplayName("Jersey Number")]
        public int JerseyNumber { get; set; }

        [DisplayName("Team Name")]
        public string TeamName { get; set; }
        public Team Team { get; set; }
    }
}