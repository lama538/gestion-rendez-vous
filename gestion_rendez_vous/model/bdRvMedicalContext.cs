﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace gestion_rendez_vous.model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    internal class bdRvMedicalContext:DbContext
    {
        public bdRvMedicalContext() :base("bdRvMedicalContext") { }

        public DbSet<personne> personnes { get; set; }
        public DbSet<patient> patients { get; set; }

        public DbSet<Utilisateur> utilisateurs{ get; set; }

        public DbSet<Medecin> medecins { get; set; }
        public DbSet<Secretaire> secretaires{ get; set; }
        public DbSet<Agenda> agendas { get; set; }

        public DbSet<RendezVous> rendezVous { get; set; }

        public DbSet<specialite> specialites { get; set; }
        public DbSet<groupesanguin> groupesanguin { get; set; }
    }
}
