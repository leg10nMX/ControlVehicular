﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlVehicular.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string UnitNumber { get; set; }
        public int Year { get; set; }
        public int Kilometrage { get; set; }
    }
}