﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRest.Entities
{
    public class SoccerTeam : Entity
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public string Manager { get; set; }
    }
}
