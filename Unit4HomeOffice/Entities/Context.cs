using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace Unit4HomeOffice.Entities
{
    public class Context : DbContext
    {

        public Context() : base("name=Context")
        {
           
        }

        public DbSet<Consultants> Consultants { get; set; }

        public DbSet<Trainings> Trainings { get; set; }

        public DbSet<TrainingDetails> TrainingDetails { get; set; }

        public DbSet<Dictionary> Dictionary { get; set; }
    }
}
