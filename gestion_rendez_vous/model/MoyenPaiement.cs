﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_rendez_vous.model
{
    public class MoyenPaiement
    {
        [Key]
        public int IdMoyenPaiement {  get; set; }

        public String libelle { get; set; }
    }
}
