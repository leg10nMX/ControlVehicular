using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControlVehicular.Models
{
    public class TravelLog
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Vehicle Vehicle { get; set; }

        public Employee Employee { get; set; }

        public UserProfile Authority { get; set; }

        public string Destination { get; set; }

        public int ExitKilometrage { get; set; }

        public DateTime ExitDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public TravelLog PreviousTravel { get; set; }

        public string Activity { get; set; }



    }
}