using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControlVehicular.Models
{
    public class FuelLog
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Vehicle Vehicle { get; set; }

        public UserProfile LogOwner { get; set; }

        public int Kilometrage { get; set; }

        public int Liters { get; set; }

        public float Cost { get; set; }

        public DateTime FilledOn { get; set; }

        public DateTime RegisteredOn { get; set; }

    }
}