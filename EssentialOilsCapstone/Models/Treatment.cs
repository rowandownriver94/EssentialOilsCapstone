﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssentialOilCapstone.Models
{
    public class Treatment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Treatment(string name)
        {
            Name = name;
        }

        public Treatment()
        {

        }
    }
}