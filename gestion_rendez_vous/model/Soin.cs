﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_rendez_vous.model
{
    public class Soin


    {
        [Key]
        public int IdSoin {  get; set; }

        public String Libelle { get; set; }
        public String Cout { get; set; }


    }
}
