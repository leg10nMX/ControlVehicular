using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControlVehicular.Models
{
    public class Vehicle
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Model { get; set; }

        public string UnitNumber { get; set; }

        public int Year { get; set; }

        public int Kilometrage { get; set; }
    }
}