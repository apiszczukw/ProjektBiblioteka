﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Model
{
    public class Authors
    {
        public int Id { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public int YearOfBirth { get; set; }
    }
}
