using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_rendez_vous.model
{
    public class Utilisateur :personne
    {
        [MaxLength(20)]
        public String Identifiant {  get; set; }
        [MaxLength(250)]
        public String Motdepasse { get; set; }

        public bool status { get; set; }
    }
}
