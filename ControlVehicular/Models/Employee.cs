using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControlVehicular.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public string LicenceNumber { get; set; }

        public DateTime LicenceExpiration { get; set; }

        public Department Department { get; set; }

    }
}