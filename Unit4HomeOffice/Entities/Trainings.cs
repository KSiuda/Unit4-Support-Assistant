using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Unit4HomeOffice.Entities.Base;

namespace Unit4HomeOffice.Entities
{
    public class Trainings : EntityBase
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Trainer { get; set; }

        public int Duration { get; set; }
    }
}
